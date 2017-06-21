using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using App.Infrastructure.Contracts.Service;

namespace App.Infrastructure.Contracts.Message
{
    [Serializable]
    [DataContract]
    public class Response<TResult> : ResponseBase<ResponseHeader, ResponseBody<TResult>, TResult>, IResponseHeader
        where TResult : new()
    {
        public Response() : base() { }
    }    
}
