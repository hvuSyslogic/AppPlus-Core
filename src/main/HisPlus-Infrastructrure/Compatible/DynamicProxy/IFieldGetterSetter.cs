using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Compatible.DynamicProxy
{
    public interface IFieldGetterSetter : IGetterSetter
    {
        FieldInfo Field { get; }
    }
}
