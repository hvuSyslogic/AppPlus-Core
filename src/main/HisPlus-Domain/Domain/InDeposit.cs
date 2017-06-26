using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InDeposit : EntityBase<int>
    {
        public InDeposit()
        {    
        }

        public string BillNo { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public decimal Amount { get; set; }
        public decimal Remain { get; set; }
        public bool IsFirst { get; set; }
        public string Remark { get; set; }
        public bool IsCancel { get; set; }
        public short? LsCancelType { get; set; }
        public System.DateTime? CancelOperTime { get; set; }
        public int? CancelOperId { get; set; }
        public int? InvoId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? HospitalId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public System.DateTime? CancelCheckTime { get; set; }
    }
}
