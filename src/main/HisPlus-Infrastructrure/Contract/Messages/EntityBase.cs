using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Contract.Messages
{
    [Serializable]
    public abstract class EntityBase<TKey> : EntityRoot, IEntity<TKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        public virtual TKey Id { get; set; }

        /// <summary>
        /// Checks if this entity is transient (it has not an Id).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>
        public virtual bool IsTransient()
        {
            if (EqualityComparer<TKey>.Default.Equals(Id, default(TKey)))
            {
                return true;
            }

            if (typeof(TKey) == typeof(int))
            {
                return Convert.ToInt32(Id) <= 0;
            }

            if (typeof(TKey) == typeof(long))
            {
                return Convert.ToInt64(Id) <= 0;
            }

            return false;
        }
    }
}