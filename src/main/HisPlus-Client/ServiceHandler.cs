﻿using System;
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
using log4net;
using Microsoft.Practices.Unity;

namespace HisPlus.Client
{
    public class ServiceHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static bool IsDistributed
        {
            get { return ConfigurationManager.Configuration.IsDistributed; }
        }

        public static void CallService<T>(Expression<Action<T>> expression)
            where T : IServiceRoot
        {
            using (T service = IsDistributed ? ProxyManager.GetProxy<T>() : HisPlusConfigurator.Container.Resolve<T>())
            {
                Perform<T>(service, expression);
            }
        }

        public static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : IServiceRoot
        {
            using (T service = IsDistributed ? ProxyManager.GetProxy<T>() : HisPlusConfigurator.Container.Resolve<T>())
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
