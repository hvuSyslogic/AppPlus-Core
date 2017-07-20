using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Collections.ObjectModel;
using System.ServiceModel;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Infrastructure.Configuration;
using HisPlus.Infrastructure;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Exceptions;
using HisPlus.Core.Infrastructure.CodeContracts;
using Castle.Core.Logging;

namespace HisPlus.Client
{
    public class ServiceHandler
    {
        #region static constructor
        
        static ServiceHandler()
        {
            IsDistributed = (HisConfigurationManager.Configuration.Provider == ProviderType.Agent);
        }        
        #endregion

        #region static properties

        public static ILogger Logger 
        {
            get { return DependencyContext.Container.Resolve<ILogger>(); }
        }

        private static bool IsDistributed { get; set; }

        #endregion

        #region GetService

        private static T GetService<T>() where T : IServiceRoot
        {
            if (IsDistributed)
            {
                return ProxyManager.GetProxy<T>();
            }

            return DependencyContext.Container.Resolve<T>();
        }

        #endregion

        #region CallService

        public static void CallService<T>(Expression<Action<T>> expression) where T : IServiceRoot
        {            
            T service = default(T);
            string errMsg = "";

            try
            {
                Requires.NotNull(expression, "expression");

                service = GetService<T>();

                expression.Compile()(service);
            }
            catch (TimeoutException ex)
            {
                errMsg = ex.BuildMessage("Service has time out");
            }
            catch (FaultException ex)
            {
                errMsg = ex.BuildMessage("Service error occurred");
            }
            catch (CommunicationException ex)
            {
                errMsg = ex.BuildMessage("Communications error occurred");
            }
            catch (Exception ex)
            {
                errMsg = ex.BuildMessage("Error has occurred");
            }
            finally
            {
                CloseClientChannel(service);

                if (!string.IsNullOrWhiteSpace(errMsg))
                {
                    Logger.Error(errMsg);

                    throw new HisPlusException(errMsg);
                }
            }
        }

        public static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression) where T : IServiceRoot
        {
            T service = default(T);
            string errMsg = "";

            try
            {
                Requires.NotNull(expression, "expression");
                
                service = GetService<T>();

                return expression.Compile()(service);
            }
            catch (TimeoutException ex)
            {
                errMsg = ex.BuildMessage("Service has time out");
            }
            catch (FaultException ex)
            {
                errMsg = ex.BuildMessage("Service error occurred");
            }
            catch (CommunicationException ex)
            {
                errMsg = ex.BuildMessage("Communications error occurred");
            }
            catch (Exception ex)
            {
                errMsg = ex.BuildMessage("Error has occurred");
            }
            finally
            {
                CloseClientChannel(service);

                if (!string.IsNullOrWhiteSpace(errMsg))
                {
                    Logger.Error(errMsg);

                    throw new HisPlusException(errMsg);
                }                
            }

            return default(TResult);
        }

        #endregion

        #region CloseClientChannel

        private static void CloseClientChannel<T>(T service) where T : IServiceRoot
        {
            var clientChannel = (service as IClientChannel);
            if (clientChannel != null)
            {
                if (clientChannel.State == CommunicationState.Faulted)
                {
                    clientChannel.Abort();
                }
                else
                {
                    clientChannel.Close();
                }

                clientChannel.Dispose();
            }
        }

        #endregion
    }
}
