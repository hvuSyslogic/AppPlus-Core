using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NfInfectReasonMap : EntityTypeConfiguration<NfInfectReason>
    {
        public NfInfectReasonMap()
            : this("dbo")
        {
        }

        public NfInfectReasonMap(string schema)
        {
            ToTable("NfInfectReason", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InfectId).HasColumnName(@"InfectId").IsRequired().HasColumnType("int");
            Property(x => x.InfReasonId).HasColumnName(@"InfReasonId").IsRequired().HasColumnType("int");
            Property(x => x.IsRelated).HasColumnName(@"IsRelated").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
