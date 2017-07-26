using HisPlus.Infrastructure.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Contract.Messages
{
    public abstract class absModel : BaseCloneableObject, IComparable<absModel>, IModel
    {        
        public bool IsModify { get; set; }

        public bool IsSelected { get; set; }        

        public string StrTemp { get; set; }

        public DateTime InputTime { get; set; }

        public abstract int ID { get; set; }

        public abstract void Fill(System.Data.IDataReader dr);

        public int SortOrder { get; set; }

        public void SetIsModify(bool isModify)
        {
            this.IsModify = isModify;
        }

        #region 转换为其它Model
        public M ConvertTo<M>() where M : absModel, new()
        {
            BindingFlags BINDING_FLAGS
            = BindingFlags.Instance | BindingFlags.Public
            | BindingFlags.GetProperty | BindingFlags.SetProperty
            | BindingFlags.GetField | BindingFlags.SetField;
            M newObject = new M();
            System.Reflection.PropertyInfo[] properties = newObject.GetType().GetProperties(BINDING_FLAGS);
            for (int k = 0; k < properties.Length; k++)
            {
                string proName = properties[k].Name;
                if (proName == "ToTalityAll")
                {
                }
                if (DynaAccessUtils.HasProperty(this, proName))
                {
                    //如果当前对象有此属性，并且类型相同
                    if (DynaAccessUtils.GetPropertyType(this, proName) ==
                        DynaAccessUtils.GetPropertyType(newObject, proName))
                    {
                        object val = DynaAccessUtils.GetProperty(this, proName);
                        if (val == null) continue;
                        DynaAccessUtils.SetProperty(newObject, properties[k].Name, val);
                    }
                }

            }
            return newObject;
        }

        public M ConvertTo<M>(string propertiesName) where M : absModel, new()
        {
            BindingFlags BINDING_FLAGS
            = BindingFlags.Instance | BindingFlags.Public
            | BindingFlags.GetProperty | BindingFlags.SetProperty
            | BindingFlags.GetField | BindingFlags.SetField;
            M newObject = new M();
            System.Reflection.PropertyInfo[] properties = newObject.GetType().GetProperties(BINDING_FLAGS);
            for (int k = 0; k < properties.Length; k++)
            {
                string proName = properties[k].Name;
                if (DynaAccessUtils.HasProperty(this, proName) && propertiesName.IndexOf(proName) > -1)
                {
                    //如果当前对象有此属性，并且类型相同
                    if (DynaAccessUtils.GetPropertyType(this, proName) ==
                        DynaAccessUtils.GetPropertyType(newObject, proName))
                    {
                        object val = DynaAccessUtils.GetProperty(this, proName);
                        if (val == null) continue;
                        DynaAccessUtils.SetProperty(newObject, properties[k].Name, val);
                    }
                }

            }
            return newObject;
        }
        #endregion

        #region Equals
        public bool Equals(absModel comparedTo)
        {
            if (this.SortOrder == comparedTo.SortOrder)
            {
                return true;
            }
            return false;
        }
        #endregion

        protected bool CheckHasFiled(IDataReader datareader, string filedName)
        {
            for (int i = 0; i < datareader.FieldCount; i++)
            {
                if (datareader.GetName(i).ToLower() == filedName.ToLower())
                    return true;
            }
            return false;
        }

        protected string ConvertIntToBoolSting(string value)
        {
            string boolString = "";
            switch (value)
            {
                case "1":
                    boolString = "true";
                    break;
                case "0":
                    boolString = "false";
                    break;
                default:
                    boolString = value;
                    break;
            }
            return boolString;
        }

        #region Compare To
        public int CompareTo(absModel comparedTo)
        {
            return this.SortOrder.CompareTo(comparedTo.SortOrder);
        }
        #endregion
        
        #region Compare To
        public int CompareTo(absModel comparedTo, string key)
        {
            string[] keys = key.Split(',');
            for (int i = 0; i < keys.Length; i++)
            {
                int temp = CompareToByKey(comparedTo, keys[i]);
                if (temp != 0) return temp;
            }
            return 0;
        }

        public int CompareTo(absModel comparedTo, string key, EnumCompareToType computeType, bool isToAfter)
        {
            string[] keys = key.Split(',');
            for (int i = 0; i < keys.Length; i++)
            {
                int temp = CompareToByKey(comparedTo, keys[i], computeType, isToAfter);
                if (temp != 0) return temp;
            }
            return 0;
        }

        private int CompareToByKey(absModel comparedTo, string key)
        {
            string a1 = DynaAccessUtils.GetProperty(this, key).ToString();
            string a2 = DynaAccessUtils.GetProperty(comparedTo, key).ToString();
            if (((DynaAccessUtils.GetPropertyType(this, key).ToString() == "System.Int32" && DynaAccessUtils.GetPropertyType(comparedTo, key).ToString() == "System.Int32")
                || (DynaAccessUtils.GetPropertyType(this, key).ToString() == "System.Double" && DynaAccessUtils.GetPropertyType(comparedTo, key).ToString() == "System.Double"))
                && a1.IsNumeric() && a2.IsNumeric())
            {
                if (Decimal.Parse(a1) - Decimal.Parse(a2) > 0)
                    return 1;
                else if (Decimal.Parse(a1) - Decimal.Parse(a2) == 0)
                    return 0;
                else
                    return -1;
            }
            if (DynaAccessUtils.GetPropertyType(this, key).ToString() == "System.DateTime" && DynaAccessUtils.GetPropertyType(comparedTo, key).ToString() == "System.DateTime" && a1.IsDate() && a2.IsDate())
                return DateTime.Compare(DateTime.Parse(a1), DateTime.Parse(a2));
            return System.String.Compare(a1, a2);
        }

        /// <summary>
        /// 属性比较
        /// </summary>
        /// <param name="comparedTo">比较的 T wehre T:absModel  </param>
        /// <param name="key">属性</param>
        /// <param name="comparedType">比较类型 Number,String,DateTime</param>
        /// <param name="isAfter">不符合规则的是否放在最后</param>
        /// <returns></returns>
        private int CompareToByKey(absModel comparedTo, string key, EnumCompareToType comparedType, bool isToAfter)
        {
            string a1 = DynaAccessUtils.GetProperty(this, key).ToString();
            string a2 = DynaAccessUtils.GetProperty(comparedTo, key).ToString();


            string MaxNumber = "9999999";
            string MinNumber = "-999999";

            string MaxDateTime = "2999-12-12";
            string MinDateTime = "1900-01-01";

            if (comparedType == EnumCompareToType.Number)
            {
                a1 = a1.IsNumeric() ? a1 : isToAfter ? MaxNumber : MinNumber;
                a2 = a2.IsNumeric() ? a2 : isToAfter ? MaxNumber : MinNumber;

                if (Decimal.Parse(a1) - Decimal.Parse(a2) > 0)
                    return 1;
                else if (Decimal.Parse(a1) - Decimal.Parse(a2) == 0)
                    return 0;
                else
                    return -1;
            }
            if (comparedType == EnumCompareToType.DateTime)
            {
                a1 = a1.IsDate() ? a1 : isToAfter ? MaxDateTime : MinDateTime;
                a2 = a2.IsDate() ? a2 : isToAfter ? MaxDateTime : MinDateTime;
                return DateTime.Compare(DateTime.Parse(a1), DateTime.Parse(a2));
            }

            return System.String.Compare(a1, a2);
        }
        #endregion
    }
}
