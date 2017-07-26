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
using HisPlus.Infrastructure.Dependency;
using HisPlus.Infrastructure.Cache;

namespace HisPlus.Client
{
    /// <summary>
    /// 客户端统一调用入口
    /// </summary>
    public class ServiceHandler
    {
        #region Constructor(s)
        
        static ServiceHandler()
        {
            IsDistributed = (HisConfigurationManager.Configuration.Provider == ProviderType.Agent);
        }        
        #endregion

        #region Private Properties

        private static ILogger Logger 
        {
            get { return typeof(ServiceHandler).GetLogger(); }
        }

        private static bool IsDistributed { get; set; }

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

        //public static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression, CacheType cacheType) where T : IServiceRoot
        //{
        //    var key = typeof(TResult).GenericTypeArguments[0].Name;
        //    TResult result = CacheHandler.GetResultFromCache<TResult>(key);
        //    if (result == null)
        //    {
        //        result = CallService<T, TResult>(expression);
        //        if (cacheType == CacheType.GetAndCache)
        //        {
        //            CacheHandler.SetResultToCache<TResult>(key, result);
        //        }
        //    }

        //    return result;
        //}

        #endregion        

        #region GetService

        private static T GetService<T>() where T : IServiceRoot
        {
            if (IsDistributed)
            {
                return ProxyManager.GetProxy<T>();
            }

            return IoCManager.Container.Resolve<T>();
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
