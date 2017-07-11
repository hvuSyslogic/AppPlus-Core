using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Dtproperty : EntityBase<int>
    {
        public Dtproperty()
        {    
        }

        public int? Objectid { get; set; }
        public string Value { get; set; }
        public string Uvalue { get; set; }
        public byte[] Lvalue { get; set; }
        public int Version { get; set; }
    }
}
