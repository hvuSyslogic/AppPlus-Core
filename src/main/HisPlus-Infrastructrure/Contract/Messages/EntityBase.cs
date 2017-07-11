using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Contract.Messages
{
    public abstract class EntityBase<TKey> : EntityRoot
    {
        public virtual TKey Id { get; set; }
    }    
}