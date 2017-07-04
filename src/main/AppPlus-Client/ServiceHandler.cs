using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Collections.ObjectModel;
using System.ServiceModel;
using log4net;
using AppPlus.Infrastructure.Contract.Services;
using AppPlus.Infrastructure.Configuration;
using Microsoft.Practices.Unity;
using AppPlus.Infrastructure;
using AppPlus.Infrastructure.Contract.Messages;
using AppPlus.Infrastructure.Exceptions;
using AppPlus.Core.Infrastructure.CodeContracts;

namespace AppPlus.Client
{
    public class ServiceHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);        

        static ServiceHandler()
        {
            LocalMode = AppConfigurator.AppServiceConfig.ServiceMode == ServiceMode.Local;
        }


        private static bool LocalMode
        {
            get;
            set;
        }

        public static void CallService<T>(Expression<Action<T>> expression)
            where T : IServiceRoot
        {
            using (T service = LocalMode ? AppConfigurator.Container.Resolve<T>() : ProxyManager.GetProxy<T>())
            {
                Perform<T>(service, expression);
            }
        }

        public static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : IServiceRoot
        {
            using (T service = LocalMode ? AppConfigurator.Container.Resolve<T>() : ProxyManager.GetProxy<T>())
            {
                return Perform<T, TResult>(service, expression);
            }
        }

        private static void Perform<T>(T service, Expression<Action<T>> action)
            where T : IServiceRoot
        {
            Requires.NotNull(action, "action");
            
            try
            {
                action.Compile()(service);
            }
            catch (Exception ex)
            {
                string description = "Exception caught at Client Application ServiceHandler";
                string errMsg = ex.BuildMessage(description);

                Log.Error(errMsg);
                throw;
            }
            finally
            {
                CloseClientChannel(service);
            }            
        }

        private static TResult Perform<T, TResult>(T service, Expression<Func<T, TResult>> expression) 
            where T : IServiceRoot
        {
            Requires.NotNull(expression, "expression");

            try
            {
                return expression.Compile()(service);
            }
            catch (Exception ex)
            {
                string description = "Exception caught at Client Application ServiceHandler";
                string errMsg = ex.BuildMessage(description);

                Log.Error(errMsg);
                throw;
            }
            finally
            {
                CloseClientChannel(service);
            }
        }

        private static void CloseClientChannel<T>(T service) where T : IServiceRoot
        {
            var client = (service as IClientChannel);
            if (client != null)
            {
                if (client.State == CommunicationState.Faulted)
                {
                    client.Abort();
                }
                else
                {
                    client.Close();
                }

                client.Dispose();
            }
        }
    }
}
