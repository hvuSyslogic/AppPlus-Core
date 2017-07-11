using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InYbBalance : EntityBase<int>
    {
        public InYbBalance()
        {    
        }

        public string Invono { get; set; }
        public int Lspaytype { get; set; }
        public int Hospid { get; set; }
        public int Pattypeid { get; set; }
        public System.DateTime Fromdate { get; set; }
        public System.DateTime Todate { get; set; }
        public int Chargedays { get; set; }
        public decimal? Beprice { get; set; }
        public string Tallyno { get; set; }
        public decimal Factget { get; set; }
        public decimal Insurance { get; set; }
        public decimal Payself { get; set; }
        public decimal Amountpay { get; set; }
        public decimal Deposit { get; set; }
        public decimal Complement { get; set; }
        public decimal Arrearage { get; set; }
        public decimal Addfee { get; set; }
        public string Remark { get; set; }
        public System.DateTime Opertime { get; set; }
        public int Operid { get; set; }
        public bool Iscancel { get; set; }
        public System.DateTime? Cancelopertime { get; set; }
        public int? Canceloperid { get; set; }
        public string Cancelmemo { get; set; }
        public int? Involastid { get; set; }
        public int? Hospitalid { get; set; }
        public string Name { get; set; }
        public string Inpatno { get; set; }
        public decimal Sumfee { get; set; }
        public decimal Amountinsurance { get; set; }
        public decimal Amountfact { get; set; }
        public System.DateTime Intime { get; set; }
        public System.DateTime Outtime { get; set; }
        public byte[] Reportcontent { get; set; }
    }
}
