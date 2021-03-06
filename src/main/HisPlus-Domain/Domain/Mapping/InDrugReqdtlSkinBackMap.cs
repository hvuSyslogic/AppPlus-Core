using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDrugReqdtlSkinBackMap : EntityTypeConfiguration<InDrugReqdtlSkinBack>
    {
        public InDrugReqdtlSkinBackMap()
            : this("dbo")
        {
        }

        public InDrugReqdtlSkinBackMap(string schema)
        {
            ToTable("InDrugReqdtlSkinBack", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReqDtlId).HasColumnName(@"ReqDtlId").IsRequired().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.IsCharged).HasColumnName(@"IsCharged").IsOptional().HasColumnType("bit");
        }
    }
}
