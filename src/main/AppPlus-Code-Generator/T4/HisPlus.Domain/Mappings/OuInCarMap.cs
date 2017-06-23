using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuInCarMap : EntityTypeConfiguration<OuInCar>
    {
        public OuInCarMap()
            : this("dbo")
        {
        }

        public OuInCarMap(string schema)
        {
            ToTable("OuInCar", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.NurseOperId).HasColumnName(@"NurseOperId").IsRequired().HasColumnType("int");
            Property(x => x.DriverOperId).HasColumnName(@"DriverOperId").IsRequired().HasColumnType("int");
            Property(x => x.CarNumber).HasColumnName(@"CarNumber").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.CarTime).HasColumnName(@"CarTime").IsRequired().HasColumnType("datetime");
            Property(x => x.Distance).HasColumnName(@"Distance").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
