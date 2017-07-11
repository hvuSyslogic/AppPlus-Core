using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Core;
using HisPlus.Core.Service;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Domain;

namespace HisPlus.Services
{
	[GlobalErrorBehaviorAttribute(typeof(GlobalErrorHandler))]
    public class BsLocSystemSub2Service : AbstractService<BsLocSystemSub2, BsLocSystemSub2DTO, int>, IBsLocSystemSub2Service
    {
    }
}
