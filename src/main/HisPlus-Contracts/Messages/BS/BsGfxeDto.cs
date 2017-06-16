using AppPlus.Infrastructure.Contracts.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Contracts.Messages.BS
{
    [Serializable]
    public partial class BsGfxeDto : DtoBase<int>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string PyCode { get; set; }

        public string WbCode { get; set; }

        public short OrderBy { get; set; }

        public bool IsActive { get; set; }

        public string F1 { get; set; }

        public string F2 { get; set; }

        public string F3 { get; set; }

        public string F4 { get; set; }

        public short IconIndex { get; set; }
    }
}
