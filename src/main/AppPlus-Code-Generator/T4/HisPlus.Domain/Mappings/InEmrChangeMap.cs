using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InEmrChangeMap : EntityTypeConfiguration<InEmrChange>
    {
        public InEmrChangeMap()
            : this("dbo")
        {
        }

        public InEmrChangeMap(string schema)
        {
            ToTable("InEmrChange", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmrId).HasColumnName(@"EmrId").IsOptional().HasColumnType("int");
            Property(x => x.Content).HasColumnName(@"Content").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.Modified).HasColumnName(@"Modified").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.IsUse).HasColumnName(@"IsUse").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
