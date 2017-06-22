using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblPhoneMsgMap : EntityTypeConfiguration<GblPhoneMsg>
    {
        public GblPhoneMsgMap()
            : this("dbo")
        {
        }

        public GblPhoneMsgMap(string schema)
        {
            ToTable("GblPhoneMsg", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PhoneNum).HasColumnName(@"PhoneNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Message).HasColumnName(@"Message").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.PlanTime).HasColumnName(@"PlanTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsSend).HasColumnName(@"IsSend").IsOptional().HasColumnType("bit");
            Property(x => x.SendTime).HasColumnName(@"SendTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
