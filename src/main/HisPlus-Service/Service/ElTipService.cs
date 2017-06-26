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
	[GlobalExceptionHandlerBehaviourAttribute(typeof(GlobalExceptionHandler))]
    public class ElTipService : AbstractService<ElTip, ElTipDTO, int>, IElTipService
    {
    }
}
