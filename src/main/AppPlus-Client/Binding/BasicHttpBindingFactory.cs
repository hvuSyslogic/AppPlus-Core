using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace AppPlus.Client.Binding
{
    public class BasicHttpBindingFactory : BindingFactory
    {
        private BasicHttpBindingFactory() { }

        public override IBindingBuilder Configure()
        {
            return new BasicHttpBindingContext();
        }

        public static BasicHttpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static BasicHttpBindingFactory _instance = new BasicHttpBindingFactory();
        }
    }
}
