using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace HisPlus.Client.Binding
{
    public interface IBindingBuilder
    {
        System.ServiceModel.Channels.Binding Build();
    }

    public abstract class BindingFactory
    {
        protected BindingFactory() { }

        public virtual IBindingBuilder Configure()
        {
            throw new NotImplementedException();
        }
    }
}
