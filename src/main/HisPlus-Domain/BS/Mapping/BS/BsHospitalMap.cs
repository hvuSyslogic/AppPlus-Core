using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsHospitalMap : EntityTypeConfiguration<BsHospital>
    {
        public BsHospitalMap()
            : this("dbo")
        {
        }

        public BsHospitalMap(string schema)
        {
            ToTable("BsHospital", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AreaId).HasColumnName(@"AreaId").IsRequired().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Area).HasColumnName(@"Area").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Farthest).HasColumnName(@"Farthest").IsOptional().HasColumnType("decimal");
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Email).HasColumnName(@"Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.ResidentPopulation).HasColumnName(@"ResidentPopulation").IsOptional().HasColumnType("int");
            Property(x => x.TentPopulation).HasColumnName(@"TentPopulation").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
