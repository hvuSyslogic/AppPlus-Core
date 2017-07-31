using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using HisPlus.Core.Abstractions.Support;

namespace HisPlus.Services
{
    public class HuSplitOutService : AbstractService<HuSplitOut, HuSplitOutDTO, int>, IHuSplitOutService
    {
    }
}
