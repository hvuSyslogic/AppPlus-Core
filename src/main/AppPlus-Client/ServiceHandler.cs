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

namespace AppPlus.Client
{
    public class ServiceHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                
        public static void CallService<T>(Expression<Action<T>> expression)
            where T : IServiceRoot
        {
            if (AppConfigurator.AppServiceConfig.ServiceMode == ServiceMode.Local)
            {
                var service = AppConfigurator.Container.Resolve<T>();
                expression.Compile()(service);
            }
            else
            {
                using (T proxy = ProxyManager.GetProxy<T>())
                {
                    Process(proxy, expression.Compile());
                }
            }
        }

        public static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : IServiceRoot
        {
            if (AppConfigurator.AppServiceConfig.ServiceMode == ServiceMode.Local)
            {
                var service = AppConfigurator.Container.Resolve<T>();
                return expression.Compile()(service);
            }
            else
            {
                using (T proxy = ProxyManager.GetProxy<T>())
                {
                    return Process(proxy, expression.Compile());
                }
            }           
        }

        private static void Process<T>(T proxy, Action<T> action)
             where T : IServiceRoot
        {
            bool responseStatus = false;

            try
            {
                action(proxy);

                var client = (proxy as IClientChannel);
                if (client.State != CommunicationState.Faulted)
                {
                    client.Close();
                    client.Dispose();
                }
            }
            //catch (FaultException<Response<object>> fe)
            catch (Exception ex)
            {
                //Log.Error(fe.Detail);
                throw;
            }
            finally
            {
                if (!responseStatus)
                {
                    try
                    {
                        var clientChannel = proxy as IClientChannel;
                        CloseClientChannel(clientChannel);
                    }
                    catch (Exception e)
                    {
                        Log.Error(e);
                        throw;
                    }
                }
            }
        }        

        private static TResult Process<T, TResult>(T proxy, Func<T, TResult> func)
             where T : IServiceRoot
        {
            bool responseStatus = false;
            TResult result = default(TResult);

            try
            {
                result = func(proxy);
                var client = (proxy as IClientChannel);
                if (client.State != CommunicationState.Faulted)
                {
                    client.Close();
                    client.Dispose();
                }
                responseStatus = true;
            }
            //catch (FaultException<Response<object>> fe)
            catch(Exception ex)
            {
                //Log.Error(fe);
                throw;
            }
            finally
            {
                if (!responseStatus)               
                {
                    try
                    {
                        var clientChannel = proxy as IClientChannel;
                        CloseClientChannel(clientChannel);
                    }
                    catch (Exception e)
                    {
                        Log.Error(e.Message);
                        throw;
                    }
                }
            }

            return result;
        }

        private static void CloseClientChannel(IClientChannel clientChannel)
        {
            if (clientChannel != null)
            {
                clientChannel.Abort();
                clientChannel.Dispose();
            }
        }

    }
}
