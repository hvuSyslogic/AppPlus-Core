using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DynamicProxy
{
    public interface IPropertyGetterSetter : IGetterSetter
    {
        PropertyInfo Property { get; }
    }
}
