using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HisPlus.WCF.Host
{
    public class Constants
    {
        //public const string ServiceHostDefinition = "<%@ ServiceHost Language=\"C#\" Debug=\"{0}\" Service=\"{1}\" Factory=\"{2}\" %>";
        public const string ServiceHostDefinition = "<%@ ServiceHost Service=\"{0}\" Factory=\"Castle.Facilities.WcfIntegration.DefaultServiceHostFactory, Castle.Facilities.WcfIntegration\" %>";        
        public const string ServicePathSeparator = "/";
        public const string ServiceFileExtension = ".svc";
        public const string ServicePrefix = "";
    }
}