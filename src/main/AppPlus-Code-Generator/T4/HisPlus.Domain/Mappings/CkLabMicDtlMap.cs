using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkLabMicDtlMap : EntityTypeConfiguration<CkLabMicDtl>
    {
        public CkLabMicDtlMap()
            : this("dbo")
        {
        }

        public CkLabMicDtlMap(string schema)
        {
            ToTable("CkLabMicDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MicId).HasColumnName(@"MicId").IsRequired().HasColumnType("int");
            Property(x => x.DrugId).HasColumnName(@"DrugId").IsOptional().HasColumnType("int");
            Property(x => x.Result).HasColumnName(@"Result").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsMic).HasColumnName(@"LsMic").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
