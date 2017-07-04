using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InEmrScoreMap : EntityTypeConfiguration<InEmrScore>
    {
        public InEmrScoreMap()
            : this("dbo")
        {
        }

        public InEmrScoreMap(string schema)
        {
            ToTable("InEmrScore", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Emrqcitemid).HasColumnName(@"EMRQCITEMID").IsOptional().HasColumnType("int");
            Property(x => x.Hospid).HasColumnName(@"HOSPID").IsOptional().HasColumnType("int");
            Property(x => x.Emritemscore).HasColumnName(@"EMRITEMSCORE").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Emrscore).HasColumnName(@"EMRSCORE").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Isscore).HasColumnName(@"ISSCORE").IsOptional().HasColumnType("bit");
            Property(x => x.Partscore).HasColumnName(@"PARTSCORE").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
