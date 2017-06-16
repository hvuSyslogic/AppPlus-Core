using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Infrastructure.Contracts.Message;

namespace App.Infrastructure.Contracts.Service
{
    public interface IResponseHeader        
    {
        ResponseHeader Header { get; set; }     
    }
}
