using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsLocationMap : EntityTypeConfiguration<BsLocation>
    {
        public BsLocationMap()
            : this("dbo")
        {
        }

        public BsLocationMap(string schema)
        {
            ToTable("BsLocation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsRequired().HasColumnType("smallint");
            Property(x => x.IsForwomen).HasColumnName(@"IsForwomen").IsRequired().HasColumnType("bit");
            Property(x => x.PhoneCode).HasColumnName(@"PhoneCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.MedicineRatio).HasColumnName(@"MedicineRatio").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.SpecialityId).HasColumnName(@"SpecialityId").IsOptional().HasColumnType("int");
            Property(x => x.BedSum).HasColumnName(@"BedSum").IsOptional().HasColumnType("smallint");
            Property(x => x.BaSysCode).HasColumnName(@"BaSysCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Director).HasColumnName(@"Director").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DeptTypeId).HasColumnName(@"DeptTypeId").IsOptional().HasColumnType("int");
            Property(x => x.IsCostApp).HasColumnName(@"IsCostApp").IsOptional().HasColumnType("bit");
            Property(x => x.AppLevel).HasColumnName(@"AppLevel").IsOptional().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Area).HasColumnName(@"Area").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OuRoomId).HasColumnName(@"OuRoomId").IsOptional().HasColumnType("int");
            Property(x => x.InRoomId).HasColumnName(@"InRoomId").IsOptional().HasColumnType("int");
            Property(x => x.IsPriceSub).HasColumnName(@"IsPriceSub").IsOptional().HasColumnType("bit");
        }
    }
}
