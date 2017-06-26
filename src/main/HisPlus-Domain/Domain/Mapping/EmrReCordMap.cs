using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class EmrReCordMap : EntityTypeConfiguration<EmrReCord>
    {
        public EmrReCordMap()
            : this("dbo")
        {
        }

        public EmrReCordMap(string schema)
        {
            ToTable("EmrReCords", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Intime).HasColumnName(@"INTIME").IsOptional().HasColumnType("datetime");
            Property(x => x.Outtime).HasColumnName(@"OUTTIME").IsOptional().HasColumnType("datetime");
            Property(x => x.Hospid).HasColumnName(@"HOSPID").IsOptional().HasColumnType("int");
            Property(x => x.Modifytime).HasColumnName(@"MODIFYTIME").IsOptional().HasColumnType("datetime");
            Property(x => x.Reccontent).HasColumnName(@"RECCONTENT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Firstretime).HasColumnName(@"FIRSTRETIME").IsOptional().HasColumnType("datetime");
            Property(x => x.Inemrid).HasColumnName(@"INEMRID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.Ismodify).HasColumnName(@"ISMODIFY").IsOptional().HasColumnType("bit");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
        }
    }
}
