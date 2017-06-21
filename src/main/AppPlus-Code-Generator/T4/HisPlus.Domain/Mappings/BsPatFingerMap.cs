using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatFingerMap : EntityTypeConfiguration<BsPatFinger>
    {
        public BsPatFingerMap()
            : this("dbo")
        {
        }

        public BsPatFingerMap(string schema)
        {
            ToTable("BsPatFinger", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.FingerPrint).HasColumnName(@"FingerPrint").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(4000);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
