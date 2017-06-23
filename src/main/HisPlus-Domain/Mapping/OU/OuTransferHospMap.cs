using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuTransferHospMap : EntityTypeConfiguration<OuTransferHosp>
    {
        public OuTransferHospMap()
            : this("dbo")
        {
        }

        public OuTransferHospMap(string schema)
        {
            ToTable("OuTransferHosp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsRequired().HasColumnType("int");
            Property(x => x.OutTime).HasColumnName(@"OutTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Reason).HasColumnName(@"Reason").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.ReturnTime).HasColumnName(@"ReturnTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReturnMemo).HasColumnName(@"ReturnMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ReturnOperTime).HasColumnName(@"ReturnOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReturnOperId).HasColumnName(@"ReturnOperID").IsOptional().HasColumnType("int");
        }
    }
}
