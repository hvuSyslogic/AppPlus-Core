using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DynamicProxy
{
    public interface IGetterSetter
    {
        object Get(object target);

        void Set(object target, object value);

        System.Type PropertyType { get; }

        string PropertyName { get; }
    }
}
