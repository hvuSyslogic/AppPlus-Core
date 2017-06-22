using AppPlus.Core.Service;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using HisPlus.Domain.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contract.Services
{
    // The table 'BsEvaluate' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsEvaluateService : AbstractService<BsEvaluate, BsEvaluateDTO>, IBsEvaluateService
    {
    }
}
