using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using Castle.Core.Logging;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Exceptions;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Core.Hosting
{
    /// <summary>
    /// https://blogs.msdn.microsoft.com/carlosfigueira/2011/06/07/wcf-extensibility-ierrorhandler/
    /// https://www.codeproject.com/Articles/899342/WCF-Global-Exception-Handling
    /// </summary>
    public class GlobalErrorHandler : IErrorHandler
    {
        private ILogger Logger 
        {
            get { return GetType().GetLogger(); } 
        }

        public void ProvideFault(System.Exception error, MessageVersion version, ref Message msg)
        {
            string description = "Exception caught at Service Application GlobalErrorHandler";
            string errMsg = error.BuildMessage(description);

            Logger.Error(errMsg);

            var exception = new FaultException(errMsg);

            MessageFault msgFault = exception.CreateMessageFault();

            msg = Message.CreateMessage(version, msgFault, exception.Action);
        }

        public bool HandleError(Exception error)
        {           
            return true;
        }
    }
}
