using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Compatible.DynamicProxy;

namespace HisPlus.Infrastructure.Compatible
{
    public abstract class BaseCloneableObject : ICloneable
    {
        public object Clone()
        {
            BindingFlags BINDING_FLAGS = BindingFlags.Instance | BindingFlags.Public
                | BindingFlags.GetProperty | BindingFlags.SetProperty
                | BindingFlags.GetField | BindingFlags.SetField;
            
            object clonedObject = Activator.CreateInstance(this.GetType());

            FieldInfo[] fields = clonedObject.GetType().GetFields(BINDING_FLAGS);

            int i = 0;

            Type cloneableType = null;

            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                cloneableType = fi.FieldType.GetInterface("ICloneable", true);
                if (cloneableType != null)
                {
                    ICloneable cloneable = (ICloneable)fi.GetValue(this);
                    fields[i].SetValue(clonedObject, cloneable.Clone());
                }
                else
                {
                    fields[i].SetValue(clonedObject, fi.GetValue(this));
                }

                Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);
                if (IEnumerableType != null)
                {
                    IEnumerable IEnum = (IEnumerable)fi.GetValue(this);                 
                    Type listType = fields[i].FieldType.GetInterface("IList", true);
                    Type dictionaryType = fields[i].FieldType.GetInterface("IDictionary", true);

                    int j = 0;
                    if (listType != null)
                    {                     
                        IList list = (IList)fields[i].GetValue(clonedObject);

                        foreach (object obj in IEnum)
                        {
                            cloneableType = obj.GetType().GetInterface("ICloneable", true);

                            if (cloneableType != null)
                            {
                                ICloneable clone = (ICloneable)obj;

                                list[j] = clone.Clone();
                            }

                            j++;
                        }
                    }
                    else if (dictionaryType != null)
                    {
                        IDictionary dic = (IDictionary)fields[i].GetValue(clonedObject);
                        j = 0;
                        foreach (DictionaryEntry de in IEnum)
                        {

                            cloneableType = de.Value.GetType().GetInterface("ICloneable", true);

                            if (cloneableType != null)
                            {
                                ICloneable clone = (ICloneable)de.Value;

                                dic[de.Key] = clone.Clone();
                            }
                            j++;
                        }
                    }
                }
                i++;
            }
            PropertyInfo[] properties = clonedObject.GetType().GetProperties(BINDING_FLAGS);
            for (int k = 0; k < properties.Length; k++)
            {
                object val = DynaAccessUtils.GetProperty(this, properties[k].Name);
                if (val == null) continue;
                DynaAccessUtils.SetProperty(clonedObject, properties[k].Name, val);
            }

            return clonedObject;
        }
    }
}
