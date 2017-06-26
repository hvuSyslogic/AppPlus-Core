using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPatFormTranMap : EntityTypeConfiguration<ElPatFormTran>
    {
        public ElPatFormTranMap()
            : this("dbo")
        {
        }

        public ElPatFormTranMap(string schema)
        {
            ToTable("ElPatFormTran", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatFormId).HasColumnName(@"PatFormId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.ChangeTime).HasColumnName(@"ChangeTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ChangeOperId).HasColumnName(@"ChangeOperId").IsOptional().HasColumnType("int");
            Property(x => x.Reason).HasColumnName(@"Reason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.FromHospital).HasColumnName(@"FromHospital").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ToHospital).HasColumnName(@"ToHospital").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecieveTime).HasColumnName(@"RecieveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.RecieveOperId).HasColumnName(@"RecieveOperId").IsOptional().HasColumnType("int");
            Property(x => x.Disposal).HasColumnName(@"Disposal").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
        }
    }
}
