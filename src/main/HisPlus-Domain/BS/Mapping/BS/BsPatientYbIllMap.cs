using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatientYbIllMap : EntityTypeConfiguration<BsPatientYbIll>
    {
        public BsPatientYbIllMap()
            : this("dbo")
        {
        }

        public BsPatientYbIllMap(string schema)
        {
            ToTable("BsPatientYBIll", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatTyeId).HasColumnName(@"PatTyeId").IsRequired().HasColumnType("int");
            Property(x => x.YbIllId).HasColumnName(@"YbIllId").IsRequired().HasColumnType("int");
            Property(x => x.MedicareNo).HasColumnName(@"MedicareNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
        }
    }
}
