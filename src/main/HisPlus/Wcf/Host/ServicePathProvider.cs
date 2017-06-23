﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace HisPlus.Wcf.Host
{
    public class ServicePathProvider : VirtualPathProvider
    {        
        public override VirtualFile GetFile(string virtualPath)
        {
            if (!this.IsServiceCall(virtualPath))
            {
                return this.Previous.GetFile(virtualPath);
            }

            return new ServiceFile(virtualPath);
        }

        private bool IsServiceCall(string virtualPath)
        {
            virtualPath = VirtualPathUtility.ToAppRelative(virtualPath);
            
            return virtualPath.ToUpper().StartsWith(string.Format("~/{0}", string.Empty));
            
            //return virtualPath.ToUpper().StartsWith(string.Format("~/{0}", ServiceHostConfiguration.Prefix));
        }
        
        public override bool FileExists(string virtualPath)
        {
            if (!this.IsServiceCall(virtualPath))
            {
                return this.Previous.FileExists(virtualPath);
            }
                
            return true;
        }

    }
}