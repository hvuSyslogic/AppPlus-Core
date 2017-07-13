using HisPlus.Core.EntityFramework;
using HisPlus.Infrastructure.Contract.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Core.Service
{
    [GlobalErrorBehaviorAttribute(typeof(GlobalErrorHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CommonService : ServiceRoot, ICommonService
    {       
    }
}