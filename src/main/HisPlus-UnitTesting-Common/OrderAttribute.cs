using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.UnitTesting.Common
{
    public class OrderAttribute : Attribute
    {
        public int I { get; set; }

        public OrderAttribute(int i)
        {
            I = i;
        }
    }
}
