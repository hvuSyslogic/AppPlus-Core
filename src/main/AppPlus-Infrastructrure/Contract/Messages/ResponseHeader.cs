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
    public class ResponseHeader
    {
        private ResponseStatus _status = ResponseStatus.Error;

        public ResponseHeader() { }       

        [DataMember(Order = 10)]
        public ResponseStatus Status 
        {
            get 
            {
                return _status; 
            }

            set
            {
                _status = value;
                if (_status == ResponseStatus.OK)
                {
                    ErrorType = _status.ToString();
                    if (Errors != null)
                    {
                        //Array.Clear(Errors, 0, Errors.Length - 1);
                        Errors.Clear();
                    }                    
                }
            } 
        }

        [DataMember(Order=20)]
        public string ErrorType { get; set; }

        [DataMember(Order = 30)]
        public List<Error> Errors { get; set; }
    }
}
