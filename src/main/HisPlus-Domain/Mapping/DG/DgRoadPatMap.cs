using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgRoadPatMap : EntityTypeConfiguration<DgRoadPat>
    {
        public DgRoadPatMap()
            : this("dbo")
        {
        }

        public DgRoadPatMap(string schema)
        {
            ToTable("DgRoadPat", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.RoadId).HasColumnName(@"RoadId").IsRequired().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsChk).HasColumnName(@"IsChk").IsOptional().HasColumnType("bit");
            Property(x => x.ChkOperTime).HasColumnName(@"ChkOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ChkOperId).HasColumnName(@"ChkOperID").IsOptional().HasColumnType("int");
        }
    }
}
