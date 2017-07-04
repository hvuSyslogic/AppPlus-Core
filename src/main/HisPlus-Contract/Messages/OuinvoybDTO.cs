using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuinvoybDTO : DtoBase<int>
    {
        public OuinvoybDTO()
        {
        }

        [DataMember]
        public int? Invoid { get; set; }

        [DataMember]
        public decimal? Factyp { get; set; }

        [DataMember]
        public decimal? Factjz { get; set; }

        [DataMember]
        public decimal? Allfactyp { get; set; }

        [DataMember]
        public decimal? Allfactjz { get; set; }

        [DataMember]
        public decimal? Otherfact { get; set; }

        [DataMember]
        public decimal? Ybdisc { get; set; }

        [DataMember]
        public decimal? Insurance { get; set; }

        [DataMember]
        public decimal? Underline { get; set; }

        [DataMember]
        public decimal? Insuranceb1 { get; set; }

        [DataMember]
        public decimal? Insuranceb2 { get; set; }

        [DataMember]
        public decimal? Insuranceb3 { get; set; }

        [DataMember]
        public decimal? Payself { get; set; }

        [DataMember]
        public decimal? Selfpaydisc { get; set; }

        [DataMember]
        public decimal? Selfpayb1 { get; set; }

        [DataMember]
        public decimal? Selfpayb2 { get; set; }

        [DataMember]
        public decimal? Selfpayb3 { get; set; }

        [DataMember]
        public decimal? Outtopselffee { get; set; }

        [DataMember]
        public decimal? Selffee { get; set; }

        [DataMember]
        public string Accountattribute { get; set; }

        [DataMember]
        public decimal? Bchzylbxamount { get; set; }

        [DataMember]
        public decimal? Bcproportion { get; set; }

        [DataMember]
        public decimal? Fdamount { get; set; }

        [DataMember]
        public decimal? Kbca1 { get; set; }

        [DataMember]
        public decimal? Kbca12 { get; set; }

        [DataMember]
        public decimal? Kbca13 { get; set; }

        [DataMember]
        public decimal? Kbca16 { get; set; }

        [DataMember]
        public decimal? Kbca17 { get; set; }

        [DataMember]
        public decimal? Kbca18 { get; set; }

        [DataMember]
        public decimal? Kbca19 { get; set; }

        [DataMember]
        public decimal? Kbca2 { get; set; }

        [DataMember]
        public decimal? Kbca20 { get; set; }

        [DataMember]
        public decimal? Kbca3 { get; set; }

        [DataMember]
        public decimal? Kbca4 { get; set; }

        [DataMember]
        public decimal? Kbca5 { get; set; }

        [DataMember]
        public decimal? Kbca6 { get; set; }

        [DataMember]
        public decimal? Kbcamount { get; set; }

        [DataMember]
        public string Medicalno { get; set; }

        [DataMember]
        public decimal? Ndybcamount { get; set; }

        [DataMember]
        public decimal? Originala1 { get; set; }

        [DataMember]
        public decimal? Originala12 { get; set; }

        [DataMember]
        public decimal? Originala13 { get; set; }

        [DataMember]
        public decimal? Originala16 { get; set; }

        [DataMember]
        public decimal? Originala17 { get; set; }

        [DataMember]
        public decimal? Originala18 { get; set; }

        [DataMember]
        public decimal? Originala19 { get; set; }

        [DataMember]
        public decimal? Originala2 { get; set; }

        [DataMember]
        public decimal? Originala20 { get; set; }

        [DataMember]
        public decimal? Originala3 { get; set; }

        [DataMember]
        public decimal? Originala4 { get; set; }

        [DataMember]
        public decimal? Originala5 { get; set; }

        [DataMember]
        public decimal? Originala6 { get; set; }

        [DataMember]
        public decimal? Originalamount { get; set; }

        [DataMember]
        public decimal? Sjbca1 { get; set; }

        [DataMember]
        public decimal? Sjbca12 { get; set; }

        [DataMember]
        public decimal? Sjbca13 { get; set; }

        [DataMember]
        public decimal? Sjbca16 { get; set; }

        [DataMember]
        public decimal? Sjbca17 { get; set; }

        [DataMember]
        public decimal? Sjbca18 { get; set; }

        [DataMember]
        public decimal? Sjbca19 { get; set; }

        [DataMember]
        public decimal? Sjbca2 { get; set; }

        [DataMember]
        public decimal? Sjbca20 { get; set; }

        [DataMember]
        public decimal? Sjbca3 { get; set; }

        [DataMember]
        public decimal? Sjbca4 { get; set; }

        [DataMember]
        public decimal? Sjbca5 { get; set; }

        [DataMember]
        public decimal? Sjbca6 { get; set; }

        [DataMember]
        public decimal? Tgproportion { get; set; }

        [DataMember]
        public decimal? Wbhproportion { get; set; }

        [DataMember]
        public decimal? Zyyproportion { get; set; }

        [DataMember]
        public decimal? Zzproportion { get; set; }

        [DataMember]
        public string YbPatType { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
