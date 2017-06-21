namespace HisPlus.Domain
{
    using AppPlus.Infrastructure.Contract.Messages;
    using System.Data.Entity.ModelConfiguration;

    public class BsdocregtypeTemp36 : EntityBase<int>
    {
        public BsdocregtypeTemp36()
        {    
        }

        public string Mdinfo { get; set; }
        public string Tdinfo { get; set; }
        public string Wdinfo { get; set; }
        public string Tudinfo { get; set; }
        public string Fdinfo { get; set; }
        public string Stdinfo { get; set; }
        public string Sudinfo { get; set; }
    }
}
