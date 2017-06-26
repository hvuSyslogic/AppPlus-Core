using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InHosMzIllMap : EntityTypeConfiguration<InHosMzIll>
    {
        public InHosMzIllMap()
            : this("dbo")
        {
        }

        public InHosMzIllMap(string schema)
        {
            ToTable("InHosMzIll", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsOptional().HasColumnType("smallint");
            Property(x => x.LsWestChin).HasColumnName(@"LsWestChin").IsOptional().HasColumnType("smallint");
            Property(x => x.IsInfect).HasColumnName(@"IsInfect").IsOptional().HasColumnType("bit");
            Property(x => x.IsCoincidence).HasColumnName(@"IsCoincidence").IsOptional().HasColumnType("bit");
            Property(x => x.CheckOperId).HasColumnName(@"CheckOperId").IsOptional().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.BpGroupId).HasColumnName(@"BPGroupId").IsOptional().HasColumnType("int");
            Property(x => x.IsDg).HasColumnName(@"IsDg").IsOptional().HasColumnType("bit");
            Property(x => x.IsBp).HasColumnName(@"IsBP").IsOptional().HasColumnType("bit");
        }
    }
}
