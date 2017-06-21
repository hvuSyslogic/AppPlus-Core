using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Infrastructure.Contract.Messages
{
    [Serializable]
    [DataContract]
    [XmlSerializerFormat]
    public abstract class DtoBase<TKey> : DtoRoot
    {
        [IgnoreDataMemberAttribute]
        [DataMember(Order = 0)]
        [MessageBodyMember(Order = 0)]
        public virtual TKey Id { get; set; }
    }
}
