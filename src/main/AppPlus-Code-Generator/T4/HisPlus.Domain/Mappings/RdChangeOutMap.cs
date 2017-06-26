using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdChangeOutMap : EntityTypeConfiguration<RdChangeOut>
    {
        public RdChangeOutMap()
            : this("dbo")
        {
        }

        public RdChangeOutMap(string schema)
        {
            ToTable("RdChangeOut", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.ChangeTime).HasColumnName(@"ChangeTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Reason).HasColumnName(@"Reason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ToHospital).HasColumnName(@"ToHospital").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BackTime).HasColumnName(@"BackTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.BackDiagnose).HasColumnName(@"BackDiagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Disposal).HasColumnName(@"Disposal").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
