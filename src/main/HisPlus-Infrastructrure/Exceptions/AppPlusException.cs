using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Exceptions
{
    [Serializable]
    public class AppPlusException : Exception
    {       
        public AppPlusException()
        {

        }

        public AppPlusException(string message)
                : base(message)
        {

        }

        public AppPlusException(string message, Exception innerException)
                : base(message, innerException)
        {

        }
    }

}
