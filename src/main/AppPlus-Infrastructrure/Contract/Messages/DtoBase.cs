using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Infrastructure.Contract.Messages
{
    public abstract class DtoBase<TKey> : DtoRoot
    {        
        [DataMember(Order = 1)]
        public virtual TKey Id { get; set; }
    }
}
