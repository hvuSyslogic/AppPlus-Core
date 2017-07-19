using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Contract.Messages
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }

        bool IsTransient();
    }
}
