﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.MQ
{
    public interface IMessageProcessor
    {
        void Process(Message msg);
    }
}
