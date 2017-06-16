using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace AppPlus.Client.Binding
{
    public class NetNamedPipeBindingFactory : BindingFactory
    {
        public override IBindingBuilder Configure()
        {
            return new NetNamedPipeBindingContext();
        }

        private NetNamedPipeBindingFactory() { }

        public static NetNamedPipeBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static NetNamedPipeBindingFactory _instance = new NetNamedPipeBindingFactory();
        }
    }
}
