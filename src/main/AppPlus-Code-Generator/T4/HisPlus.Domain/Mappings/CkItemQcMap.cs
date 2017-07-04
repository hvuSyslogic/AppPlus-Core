using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkItemQcMap : EntityTypeConfiguration<CkItemQc>
    {
        public CkItemQcMap()
            : this("dbo")
        {
        }

        public CkItemQcMap(string schema)
        {
            ToTable("CkItemQc", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.QcName).HasColumnName(@"QcName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Dev3).HasColumnName(@"Dev3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Dev2).HasColumnName(@"Dev2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Dev1).HasColumnName(@"Dev1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DevM1).HasColumnName(@"DevM1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DevM2).HasColumnName(@"DevM2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DevM3).HasColumnName(@"DevM3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AvgValue).HasColumnName(@"AvgValue").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CtrlId).HasColumnName(@"CtrlId").IsOptional().HasColumnType("int");
        }
    }
}
