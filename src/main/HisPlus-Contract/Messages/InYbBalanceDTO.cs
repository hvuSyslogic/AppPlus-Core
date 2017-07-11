using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InYbBalanceDTO : DtoBase<int>
    {
        public InYbBalanceDTO()
        {
        }

        [DataMember]
        public string Invono { get; set; }

        [DataMember]
        public int Lspaytype { get; set; }

        [DataMember]
        public int Hospid { get; set; }

        [DataMember]
        public int Pattypeid { get; set; }

        [DataMember]
        public System.DateTime Fromdate { get; set; }

        [DataMember]
        public System.DateTime Todate { get; set; }

        [DataMember]
        public int Chargedays { get; set; }

        [DataMember]
        public decimal? Beprice { get; set; }

        [DataMember]
        public string Tallyno { get; set; }

        [DataMember]
        public decimal Factget { get; set; }

        [DataMember]
        public decimal Insurance { get; set; }

        [DataMember]
        public decimal Payself { get; set; }

        [DataMember]
        public decimal Amountpay { get; set; }

        [DataMember]
        public decimal Deposit { get; set; }

        [DataMember]
        public decimal Complement { get; set; }

        [DataMember]
        public decimal Arrearage { get; set; }

        [DataMember]
        public decimal Addfee { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public System.DateTime Opertime { get; set; }

        [DataMember]
        public int Operid { get; set; }

        [DataMember]
        public bool Iscancel { get; set; }

        [DataMember]
        public System.DateTime? Cancelopertime { get; set; }

        [DataMember]
        public int? Canceloperid { get; set; }

        [DataMember]
        public string Cancelmemo { get; set; }

        [DataMember]
        public int? Involastid { get; set; }

        [DataMember]
        public int? Hospitalid { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Inpatno { get; set; }

        [DataMember]
        public decimal Sumfee { get; set; }

        [DataMember]
        public decimal Amountinsurance { get; set; }

        [DataMember]
        public decimal Amountfact { get; set; }

        [DataMember]
        public System.DateTime Intime { get; set; }

        [DataMember]
        public System.DateTime Outtime { get; set; }

        [DataMember]
        public byte[] Reportcontent { get; set; }
    }
}
