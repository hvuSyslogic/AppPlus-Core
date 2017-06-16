using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core
{
    public class ExpressionUtils
    {
        //public static ClientRequest Parse<T>(Expression method)
        //{
        //    ClientRequest clientRequest = new ClientRequest();

        //    try
        //    {
        //        var methodCallExp = GetMethodCallExpression(method);

        //        clientRequest.ServiceName = typeof(T).Name;
        //        clientRequest.MethodName = methodCallExp.Method.Name;
        //        List<object> arguments = new List<object>();
        //        ReadOnlyCollection<Expression> argumentsOfExp = methodCallExp.Arguments;
        //        foreach (var arg in argumentsOfExp)
        //        {
        //            LambdaExpression lambda = Expression.Lambda(arg);
        //            Delegate compiledExpression = lambda.Compile();
        //            string name = lambda.Name;
        //            object value = compiledExpression.DynamicInvoke();
        //            arguments.Add(value);
        //        };

        //        clientRequest.Arguments = arguments;
        //    }
        //    catch (Exception ex)
        //    {
        //        //TODO: dragon luo
        //        //Client exception will be thrown
        //        throw;
        //    }
        //    finally
        //    {
        //    }

        //    return clientRequest;
        //}

        public static MethodCallExpression GetMethodCallExpression(Expression method)
        {
            LambdaExpression lambda = method as LambdaExpression;
            if (lambda == null)
            {
                throw new ArgumentNullException("method");
            }

            MethodCallExpression methodCallExp = null;

            LambdaExpression lambdaExp = method as LambdaExpression;

            switch (lambda.Body.NodeType)
            {
                case ExpressionType.Convert:
                    methodCallExp = ((UnaryExpression)lambdaExp.Body).Operand as MethodCallExpression;
                    break;

                case ExpressionType.Call:
                    methodCallExp = lambdaExp.Body as MethodCallExpression;
                    break;
            }

            return methodCallExp;
        }

        public static Expression<Func<T, bool>> True<T>()
        {
            return p => true;
        }

        public static Expression<Func<T, bool>> False<T>()
        {
            return p => false;
        }

        public static Expression<Func<T, TKey>> GetOrderExpression<T, TKey>(string propertyName)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            return Expression.Lambda<Func<T, TKey>>(Expression.Property(parameter, propertyName), parameter);
        }

        public static Expression<Func<T, bool>> Equal<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);
            return Expression.Lambda<Func<T, bool>>(Expression.Equal(member, constant), parameter);
        }

        public static Expression<Func<T, bool>> NotEqual<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);
            return Expression.Lambda<Func<T, bool>>(Expression.NotEqual(member, constant), parameter);
        }

        public static Expression<Func<T, bool>> GreaterThan<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);
            return Expression.Lambda<Func<T, bool>>(Expression.GreaterThan(member, constant), parameter);
        }

        public static Expression<Func<T, bool>> LessThan<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);
            return Expression.Lambda<Func<T, bool>>(Expression.LessThan(member, constant), parameter);
        }

        public static Expression<Func<T, bool>> CreateGreaterThanOrEqual<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);
            return Expression.Lambda<Func<T, bool>>(Expression.GreaterThanOrEqual(member, constant), parameter);
        }

        public static Expression<Func<T, bool>> LessThanOrEqual<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);
            return Expression.Lambda<Func<T, bool>>(Expression.LessThanOrEqual(member, constant), parameter);
        }

        private static Expression<Func<T, bool>> Includes<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            MethodInfo method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            ConstantExpression constant = Expression.Constant(propertyValue, typeof(string));
            return Expression.Lambda<Func<T, bool>>(Expression.Call(member, method, constant), parameter);
        }

        private static Expression<Func<T, bool>> Excludes<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            MethodInfo method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            ConstantExpression constant = Expression.Constant(propertyValue, typeof(string));
            return Expression.Lambda<Func<T, bool>>(Expression.Not(Expression.Call(member, method, constant)), parameter);
        }
    }
}
