﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace AppPlus.Client.Binding
{
    public class WebHttpBindingFactory : BindingFactory
    {
        public override IBindingBuilder Configure()
        {
            return new WebHttpBindingContext();
        }

        private WebHttpBindingFactory() { }

        public static WebHttpBindingFactory Instance
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static WebHttpBindingFactory _instance = new WebHttpBindingFactory();
        }
    }
}