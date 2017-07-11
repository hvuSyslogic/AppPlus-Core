using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using App.Infrastructure.Contracts.Service;

namespace App.Infrastructure.Contracts.Message
{
    [Serializable]
    [DataContract]
    public abstract class ResponseBase<THeader, TBody, TResult> : IResponseHeader
        where THeader : ResponseHeader, new()
        where TBody : ResponseBody<TResult>, new()    
        where TResult : new()
    {
        public ResponseBase()
        {
            Header = new ResponseHeader()
            {
                Status = ResponseStatus.OK,
                Errors = new List<Error>()
            };

            Body = new ResponseBody<TResult>();
        }

        [DataMember(Order = 10)]
        public ResponseHeader Header { get; set; }

        [DataMember(Order = 20)]
        public ResponseBody<TResult> Body { get; set; }
    }
}
