using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPlus.Core;
using AppPlus.Core.Service;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Domain;

namespace HisPlus.Services
{
	[GlobalErrorBehaviorAttribute(typeof(GlobalErrorHandler))]
    public class TrPractiseService : AbstractService<TrPractise, TrPractiseDTO, int>, ITrPractiseService
    {
    }
}
