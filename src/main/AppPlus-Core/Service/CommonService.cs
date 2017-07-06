using AppPlus.Core.EntityFramework;
using AppPlus.Infrastructure.Contract.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core.Service
{
    [GlobalErrorBehaviorAttribute(typeof(GlobalErrorHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CommonService : ServiceRoot, ICommonService
    {       
    }
}
