using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HisPlus.WCF.Host
{
    public class ServiceHostConfiguration
    {
        public static string Prefix
        {
            get { return Constants.ServicePrefix; }            
        }

        public static string Extension 
        {
            get { return Constants.ServiceFileExtension; }
        }

        public static string PathSeparator 
        {
            get { return Constants.ServicePathSeparator; }
        }
      
        public static bool Debug 
        {
            get { return true; }
        }

        public static Type HostFactoryType
        {
            get { return typeof(DynamicHostFactory); }            
        }

        public static string Definition 
        {
            get { return Constants.ServiceHostDefinition; } 
        }
    }
}