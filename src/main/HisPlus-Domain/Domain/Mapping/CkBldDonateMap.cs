using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkBldDonateMap : EntityTypeConfiguration<CkBldDonate>
    {
        public CkBldDonateMap()
            : this("dbo")
        {
        }

        public CkBldDonateMap(string schema)
        {
            ToTable("CkBldDonate", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Rhd).HasColumnName(@"RHD").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BloodTypeId).HasColumnName(@"BloodTypeId").IsOptional().HasColumnType("int");
            Property(x => x.Vollume).HasColumnName(@"Vollume").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.BloodDonor).HasColumnName(@"BloodDonor").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.Receptor).HasColumnName(@"Receptor").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
        }
    }
}
