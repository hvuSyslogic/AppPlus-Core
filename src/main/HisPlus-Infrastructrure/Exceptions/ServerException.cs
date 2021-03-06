﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Exceptions
{
    [Serializable]
    public class ServerException : HisPlusException
    {       
        public ServerException()
        {

        }

        public ServerException(string message)
                : base(message)
        {

        }

        public ServerException(string message, Exception innerException)
                : base(message, innerException)
        {

        }
    }

}
