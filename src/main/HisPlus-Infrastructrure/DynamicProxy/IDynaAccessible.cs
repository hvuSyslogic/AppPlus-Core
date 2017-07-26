using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DynamicProxy
{
    public interface IDynaAccessible
    {
        /// <summary>
        /// 得到可以动态访问的属性名称
        /// </summary>
        string[] GetPropertyNames();

        /// <summary>
        /// 设置动态属性值
        /// </summary>
        void SetProperty(string propertyName, object propertyValue);

        /// <summary>
        /// 得到动态属性值
        /// </summary>
        object GetProperty(string propertyName);

        /// <summary>
        /// 判断是否存在指定名称的属性
        /// </summary>
        bool HasProperty(string propertyName);

        /// <summary>
        /// 得到指定动态属性的类型
        /// </summary>
        Type GetPropertyType(string propertyName);
    }    
}
