using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Exceptions
{
    [Serializable]
    public class HisPlusException : Exception
    {       
        public HisPlusException()
        {

        }

        public HisPlusException(string message)
                : base(message)
        {

        }

        public HisPlusException(string message, Exception innerException)
                : base(message, innerException)
        {

        }
    }

}
