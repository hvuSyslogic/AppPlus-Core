using System;
using System.Collections.Generic;
using log4net;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using AppPlus.Infrastructure.Contract.Messages;

namespace AppPlus.Core
{    
    public class GlobalExceptionHandler : IErrorHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void ProvideFault(System.Exception error, MessageVersion version, ref Message fault)
        {
            ServiceFault serviceFault = new ServiceFault
            {
                ErrCode = 5000
            };

            if (error is DbEntityValidationException)
            {
                serviceFault.Type = typeof(DbEntityValidationException).Name;
                DbEntityValidationException ex = error as DbEntityValidationException;
                ex.EntityValidationErrors.ToList<DbEntityValidationResult>().ForEach(delegate(DbEntityValidationResult x)
                {
                    foreach(var validationError in x.ValidationErrors)
                    {
                        serviceFault.Messages.Add(validationError.ErrorMessage);
                        Log.ErrorFormat("Property Name: {0} ErrorMessage: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }

                    //serviceFault.Messages.AddRange(
                    //    from y in x.ValidationErrors
                    //    select y.ErrorMessage);
                    
                });
                GlobalExceptionHandler.Log.Error(error);
            }
            else
            {
                error = error.Unwrap();
                serviceFault.Messages.Add(error.Message);
                serviceFault.Type = error.GetType().FullName;
                GlobalExceptionHandler.Log.Error(error);
            }
            FaultException<ServiceFault> faultException = new FaultException<ServiceFault>(serviceFault, new FaultReason(serviceFault.Type));
            MessageFault fault2 = faultException.CreateMessageFault();
            fault = Message.CreateMessage(version, fault2, string.Empty);
        }

        public bool HandleError(Exception error)
        {           
            return true;
        }
    }
}
