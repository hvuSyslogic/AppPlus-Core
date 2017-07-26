using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DynamicProxy
{
    internal sealed class ListProxy : IDynaAccessProxy
    {
        private string[] _propertyNames = new string[0];

        #region IDynaAccessProxy methods

        public string[] GetPropertyNames(object target)
        {
            if (target is IList)
            {
                string[] propertyNames = new string[((IList)target).Count];
                for (int i = 0; i < ((IList)target).Count; i++)
                    propertyNames[i] = System.Convert.ToString(i);
                return propertyNames;
            }
            else
            {
                return _propertyNames;
            }
        }

        public void SetProperty(object target, string propertyName, object propertyValue)
        {
            try
            {
                int i = System.Convert.ToInt32(propertyName);

                if (target is IList)
                {
                    ((IList)target)[i] = propertyValue;
                }
                else
                {
                    throw new DynaAccessException(target.GetType().Name + " class is not a List or Array.");
                }
            }
            catch (Exception e)
            {
                throw new DynaAccessException(e);
            }
        }

        public object GetProperty(object target, string propertyName)
        {
            object value = null;

            try
            {
                int i = System.Convert.ToInt32(propertyName);

                if (target is IList)
                {
                    value = ((IList)target)[i];
                }
                else
                {
                    throw new DynaAccessException(target.GetType().Name + " class is not a List or Array.");
                }
            }
            catch (Exception e)
            {
                throw new DynaAccessException(e);
            }
            return value;
        }

        public bool HasProperty(object target, string propertyName)
        {
            try
            {
                int i = System.Convert.ToInt32(propertyName);

                if (target is IList)
                {
                    return i > -1 && i < ((IList)target).Count;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Type GetPropertyType(object target, string propertyName)
        {
            object value = null;

            try
            {
                int i = System.Convert.ToInt32(propertyName);

                if (target is IList)
                {
                    value = ((IList)target)[i];
                    if (value == null)
                    {
                        value = new object();
                    }

                    return value.GetType();
                }
                else
                {
                    throw new DynaAccessException(target.GetType().Name + " class is not a List or Array.");
                }
            }
            catch (Exception e)
            {
                throw new DynaAccessException(e);
            }
        }

        public Type ProxyType
        {
            get
            {
                return typeof(System.Collections.IList);
            }
        }

        #endregion
    }
}
