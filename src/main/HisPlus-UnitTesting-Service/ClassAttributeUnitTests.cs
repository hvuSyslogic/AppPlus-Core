using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace HisPlus.UnitTesting
{
    public class ClassAttributeUnitTests
    {
        [Fact]
        public void Null_Attribute_Test_OK()
        {
            System.Reflection.MemberInfo info = typeof(UncacheableUser);
            object[] attributes = info.GetCustomAttributes(true);
            var attribute = attributes.Where(x => (x as CacheAttribute) != null).FirstOrDefault() as CacheAttribute;

            attribute.Should().BeNull();
        }

        [Fact]
        public void Cache_Attribute_Test_OK()
        {
            System.Reflection.MemberInfo info = typeof(CacheableUser);
            object[] attributes = info.GetCustomAttributes(true);
            var attribute = attributes.Where(x => (x as CacheAttribute) != null).FirstOrDefault() as CacheAttribute;

            attribute.Should().NotBeNull();
            attribute.Enable.Should().BeTrue();

            System.Console.WriteLine(attribute);
        }
    }
    
    [AttributeUsage(AttributeTargets.Class)]
    public class CacheAttribute : Attribute
    {
        public CacheAttribute()
            : this(true)
        {

        }

        public CacheAttribute(bool enable)
        {
            Enable = enable;
        }

        public bool Enable { get; set; }
    }

    public class UncacheableUser
    {
        public string UserId { get; set; }

        public string UserName { get; set; }
    }

    [Cache]
    public class CacheableUser
    {
        public string UserId { get; set; }

        public string UserName { get; set; }
    }

}
