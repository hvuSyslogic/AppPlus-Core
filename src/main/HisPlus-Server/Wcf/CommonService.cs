using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using log4net;
using Microsoft.Practices.Unity;
using Serialize.Linq.Nodes;
using Xx.His.Contract.Message;
using Xx.His.Utils;
using Xx.His.Contract.Service;
using Xx.His.Core;

namespace AppPlus.His.Server.Support.Service
{
    [ ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    [GlobalExceptionHandlerBehaviour(typeof(GlobalExceptionHandler))]
    public class CommonService : ICommonService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private bool disposed = false;

        public byte[] Process(string serviceName, string methodName, params byte[] arguments)
        {
            object response = null;

            try
            {
                ContainerRegistration containerRegistration = IoCContainer.Instance.Registrations
                    .Where(x => x.RegisteredType.Name == serviceName)
                    .FirstOrDefault();
                if (containerRegistration == null)
                {
                    var errMessage = string.Format("'{0}' is not a valid service name in IoC container.", serviceName);
                    Log.Error(errMessage);

                    throw new ArgumentOutOfRangeException(errMessage);
                }

                Type mappedToType = containerRegistration.MappedToType;

                object[] args = Serializer.DeserializeBinary(arguments);

                response = InvokeHelper.InvokeMethod(mappedToType.Assembly.GetName().Name, mappedToType.FullName, methodName, args);
                
            }
            catch (Exception ex)
            {
                //ex.RethrowWithNoStackTraceLoss();

                var unwarpException = ex.Unwrap();
              
                Error error = new Error()
                {
                    ErrCode = 5000,
                    ErrMsg = unwarpException.Message,
                    ErrType = unwarpException.GetType().FullName
                };

                Response<object> errResponse = new Response<object>();
                errResponse.Header.Status = ResponseStatus.Error;
                errResponse.Header.ErrorType = ex.GetType().FullName;
                errResponse.Header.Errors.Add(error);
                errResponse.Body.Result = null;
                
                response = errResponse;

                Log.ErrorFormat("Exception: {0}", ex);
            }

            var result = Serializer.SerializeBinary(new object[] { response });

            return result;
        }

        public void Dispose()
        {
            Dispose(true);             
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                   //TODO:
                }
            }

            this.disposed = true;
        }

    }
}
