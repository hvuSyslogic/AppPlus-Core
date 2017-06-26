using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsDeptIncomeMap : EntityTypeConfiguration<CsDeptIncome>
    {
        public CsDeptIncomeMap()
            : this("dbo")
        {
        }

        public CsDeptIncomeMap(string schema)
        {
            ToTable("CsDeptIncome", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YearMonth).HasColumnName(@"YearMonth").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.FeeHsId).HasColumnName(@"FeeHsId").IsOptional().HasColumnType("int");
            Property(x => x.OperLocId).HasColumnName(@"OperLocId").IsRequired().HasColumnType("int");
            Property(x => x.ExcLocId).HasColumnName(@"ExcLocId").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("numeric").HasPrecision(10,2);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.Abstract).HasColumnName(@"Abstract").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
