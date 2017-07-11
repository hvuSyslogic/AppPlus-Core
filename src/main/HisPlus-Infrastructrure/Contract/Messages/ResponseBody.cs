using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace App.Infrastructure.Contracts.Message
{
    [Serializable]
    [DataContract]
    public class ResponseBody<TResult>        
    {
        public ResponseBody()
        {
            Result = default(TResult);
        }

        [DataMember]
        public TResult Result { get; set; }
    }
}