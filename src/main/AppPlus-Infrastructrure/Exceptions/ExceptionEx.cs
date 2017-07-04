using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Infrastructure.Exceptions
{
    public static class ExceptionEx
    {
        const string RETHROW_MARKER = "$$RethrowMarker$$";

        /// <summary>
        /// Rethrows an exception object without losing the existing stack trace information
        /// </summary>
        /// <param name="ex">The exception to re-throw.</param>
        /// <remarks>
        /// For more information on this technique, see
        /// http://www.dotnetjunkies.com/WebLog/chris.taylor/archive/2004/03/03/8353.aspx.
        /// The remote_stack_trace string is here to support Mono.
        /// </remarks>
        public static void RethrowWithNoStackTraceLoss(this Exception ex)
        {
#if PLATFORM_NET35
        FieldInfo remoteStackTraceString =
            typeof(Exception).GetField("_remoteStackTraceString", BindingFlags.Instance | BindingFlags.NonPublic) ??
            typeof(Exception).GetField("remote_stack_trace", BindingFlags.Instance | BindingFlags.NonPublic);

        remoteStackTraceString.SetValue(ex, ex.StackTrace + RETHROW_MARKER);
        throw ex;
#else
            System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex).Throw();
#endif
        }

        /// <summary>
        /// Unwraps an exception to remove any wrappers, like <see cref="TargetInvocationException"/>.
        /// </summary>
        /// <param name="ex">The exception to unwrap.</param>
        /// <returns>The unwrapped exception.</returns>
        public static Exception Unwrap(this Exception ex)
        {
            while (true)
            {
                //var tiex = ex as TargetInvocationException;
                //if (tiex == null)
                //    return ex;

                //ex = tiex.InnerException;

                var innerException = ex.InnerException;
                if (innerException == null)
                    return ex;

                ex = innerException;
            }
        }

        public static string BuildMessage(this System.Exception error, string description)
        {
            StringBuilder errBuilder = new StringBuilder();
            errBuilder.AppendLine(description);

            DbEntityValidationException entityValidationException = error as DbEntityValidationException;
            if (entityValidationException != null)
            {
                entityValidationException.EntityValidationErrors.ToList<DbEntityValidationResult>()
                    .ForEach(delegate(DbEntityValidationResult x)
                    {
                        foreach (var validationError in x.ValidationErrors)
                        {
                            errBuilder.AppendLine(validationError.ErrorMessage);
                            errBuilder.AppendLine();
                            errBuilder.AppendFormat("Property Name: {0} ErrorMessage: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    });
            }
            else
            {
                errBuilder.AppendFormat("   Exception: {0}", error.GetType().FullName);
                errBuilder.AppendLine();
                errBuilder.AppendFormat("   Method: {0}", error.TargetSite.Name);
                errBuilder.AppendLine();
                errBuilder.AppendFormat("   Message: {0}", error.Message);
                errBuilder.AppendLine();
                errBuilder.AppendFormat("   StackTrace: {0}", error.StackTrace);

                Exception innerEx = null;
                if (error.InnerException != null)
                {
                    innerEx = error.Unwrap();
                    errBuilder.AppendLine();
                    errBuilder.AppendFormat("   Exception: {0}", innerEx.GetType().FullName);
                    errBuilder.AppendLine();
                    errBuilder.AppendFormat("   InnerException Message: {0}", innerEx.Message);
                    errBuilder.AppendLine();
                    errBuilder.AppendFormat("   InnerException StackTrace: {0}", error.StackTrace);
                }
            }

            return errBuilder.ToString();
        }
    }
}
