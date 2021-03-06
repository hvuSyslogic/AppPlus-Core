﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Exceptions
{
    [Serializable]
    public class ClientException : HisPlusException
    {       
        public ClientException()
        {

        }

        public ClientException(string message)
                : base(message)
        {

        }

        public ClientException(string message, Exception innerException)
                : base(message, innerException)
        {

        }
    }

}
