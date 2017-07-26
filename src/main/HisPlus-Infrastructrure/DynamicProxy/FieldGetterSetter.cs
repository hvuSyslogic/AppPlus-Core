using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DynamicProxy
{
    internal sealed class FieldGetterSetter : IFieldGetterSetter
    {
        private readonly FieldInfo _field;

        public FieldGetterSetter(FieldInfo field)
        {
            this._field = field;
        }

        #region IFieldGetterSetter Members

        public object Get(object target)
        {
            return _field.GetValue(target);
        }

        public void Set(object target, object value)
        {
            _field.SetValue(target, value);
        }

        public System.Type PropertyType
        {
            get { return _field.FieldType; }
        }

        public string PropertyName
        {
            get { return _field.Name; }
        }

        public FieldInfo Field
        {
            get { return _field; }
        }

        #endregion
    }
}
