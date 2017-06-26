using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OpsManMap : EntityTypeConfiguration<OpsMan>
    {
        public OpsManMap()
            : this("dbo")
        {
        }

        public OpsManMap(string schema)
        {
            ToTable("OpsMan", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsRequired().HasColumnType("int");
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.LsRole).HasColumnName(@"LsRole").IsRequired().HasColumnType("smallint");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DocLevId).HasColumnName(@"DocLevId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
