using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VisitRecordMap : EntityTypeConfiguration<VisitRecord>
    {
        public VisitRecordMap()
            : this("dbo")
        {
        }

        public VisitRecordMap(string schema)
        {
            ToTable("VisitRecord", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VisitTime).HasColumnName(@"VisitTime").IsOptional().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.VisitType).HasColumnName(@"VisitType").IsOptional().HasColumnType("smallint");
            Property(x => x.VisitContent).HasColumnName(@"VisitContent").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.PatId).HasColumnName(@"PatID").IsRequired().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegID").IsRequired().HasColumnType("int");
            Property(x => x.BackContent).HasColumnName(@"BackContent").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.VisitStatus).HasColumnName(@"VisitStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.AppraiseType).HasColumnName(@"AppraiseType").IsOptional().HasColumnType("smallint");
        }
    }
}
