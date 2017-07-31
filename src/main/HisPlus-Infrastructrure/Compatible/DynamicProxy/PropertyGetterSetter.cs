using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Compatible.DynamicProxy
{
    internal sealed class PropertyGetterSetter : IPropertyGetterSetter
    {
        private PropertyInfo _property;

        public PropertyGetterSetter(PropertyInfo property)
        {
            this._property = property;
        }

        #region IPropertyGetterSetter Members

        public object Get(object target)
        {
            return _property.GetValue(target, null);
        }

        public void Set(object target, object value)
        {
            _property.SetValue(target, value, null);
        }

        public System.Type PropertyType
        {
            get { return _property.PropertyType; }
        }

        public string PropertyName
        {
            get { return _property.Name; }
        }

        public PropertyInfo Property
        {
            get { return _property; }
        }

        #endregion
    }
}
