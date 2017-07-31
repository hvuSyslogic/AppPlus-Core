using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Core.Abstractions.Support;
using HisPlus.Domain;

namespace HisPlus.Services
{
	public class PsDrugActionService : AbstractService<PsDrugAction, PsDrugActionDTO, int>, IPsDrugActionService
	{
	}
}
