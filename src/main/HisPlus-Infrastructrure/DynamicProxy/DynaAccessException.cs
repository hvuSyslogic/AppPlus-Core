using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DynamicProxy
{
    public class DynaAccessException : System.ApplicationException
    {
        public DynaAccessException()
            : base("A property reflection error has occurred.")
        {
        }

        public DynaAccessException(Exception ex)
            : base(ex.Message, ex)
        {
        }

        public DynaAccessException(string message)
            : base(message)
        {
        }

        public DynaAccessException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected DynaAccessException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
