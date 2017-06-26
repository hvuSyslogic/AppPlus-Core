using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkFormulaMap : EntityTypeConfiguration<CkFormula>
    {
        public CkFormulaMap()
            : this("dbo")
        {
        }

        public CkFormulaMap(string schema)
        {
            ToTable("CkFormula", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.Formula).HasColumnName(@"Formula").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
        }
    }
}
