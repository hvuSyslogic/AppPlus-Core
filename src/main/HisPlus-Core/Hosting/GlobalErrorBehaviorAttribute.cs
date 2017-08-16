using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Collections.ObjectModel;

namespace HisPlus.Core.Hosting
{
    public class GlobalErrorBehaviorAttribute : Attribute, IServiceBehavior
    {
        private readonly Type errorHandlerType;

        public GlobalErrorBehaviorAttribute(Type errorHandlerType)
        {
            this.errorHandlerType = errorHandlerType;
        }

        #region IServiceBehavior Members
        public void Validate(ServiceDescription description, ServiceHostBase serviceHostBase)
        {
        }

        public void AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, 
            Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase)
        {
            IErrorHandler errorHandler;

            try
            {
                errorHandler = (IErrorHandler)Activator.CreateInstance(errorHandlerType);
            }
            catch (MissingMethodException mme)
            {
                throw new ArgumentException("The errorHandlerType specified in the GlobalErrorBehaviorAttribute constructor must have a public empty constructor.", mme);
            }
            catch (InvalidCastException ice)
            {
                throw new ArgumentException("The errorHandlerType specified in the GlobalExceptionHandlerBehaviour constructor must implement System.ServiceModel.Dispatcher.IErrorHandler.", ice);
            }

            foreach (ChannelDispatcherBase channelDispatcherBase in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher channelDispatcher = channelDispatcherBase as ChannelDispatcher;
                if (channelDispatcher != null)
                {
                    channelDispatcher.ErrorHandlers.Add(errorHandler);
                }
            }
        }
        #endregion
    }
}