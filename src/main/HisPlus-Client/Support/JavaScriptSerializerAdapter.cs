using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace HisPlus.Client.Support
{
    public class JavaScriptSerializerAdapter : ISerializerAdapter
    {
        private JavaScriptSerializer serializer;

        public JavaScriptSerializerAdapter()
        {
            serializer = new JavaScriptSerializer();
        }

        public string Serialize(object obj)
        {
            return serializer.Serialize(obj);
        }

        public T Deserialize<T>(string input)
        {
            return serializer.Deserialize<T>(input);
        }
    }
}
