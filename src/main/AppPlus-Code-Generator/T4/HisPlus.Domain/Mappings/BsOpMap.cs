using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsOpMap : EntityTypeConfiguration<BsOp>
    {
        public BsOpMap()
            : this("dbo")
        {
        }

        public BsOpMap(string schema)
        {
            ToTable("BsOPS", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(8);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.LsClass).HasColumnName(@"LsClass").IsOptional().HasColumnType("smallint");
            Property(x => x.LsAsa).HasColumnName(@"LsASA").IsOptional().HasColumnType("smallint");
            Property(x => x.IsEmergency).HasColumnName(@"IsEmergency").IsOptional().HasColumnType("bit");
            Property(x => x.AnaesId).HasColumnName(@"AnaesId").IsOptional().HasColumnType("int");
            Property(x => x.Minutes).HasColumnName(@"Minutes").IsOptional().HasColumnType("int");
            Property(x => x.IsImplant).HasColumnName(@"IsImplant").IsOptional().HasColumnType("bit");
            Property(x => x.IsImglass).HasColumnName(@"IsImglass").IsOptional().HasColumnType("bit");
            Property(x => x.IsOpsDrug).HasColumnName(@"IsOPSDrug").IsOptional().HasColumnType("bit");
            Property(x => x.DangerPoint).HasColumnName(@"DangerPoint").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
        }
    }
}
