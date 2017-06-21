using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsRegPatAmountMap : EntityTypeConfiguration<BsRegPatAmount>
    {
        public BsRegPatAmountMap()
            : this("dbo")
        {
        }

        public BsRegPatAmountMap(string schema)
        {
            ToTable("BsRegPatAmount", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RegTypeId).HasColumnName(@"RegTypeID").IsRequired().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeID").IsRequired().HasColumnType("int");
            Property(x => x.RegFee).HasColumnName(@"RegFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DiagnoFee).HasColumnName(@"DiagnoFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFee1).HasColumnName(@"OtherFee1").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFee2).HasColumnName(@"OtherFee2").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PaySel).HasColumnName(@"PaySel").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.TallyFee).HasColumnName(@"TallyFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
