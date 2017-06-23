using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OugetSchInfoMap : EntityTypeConfiguration<OugetSchInfo>
    {
        public OugetSchInfoMap()
            : this("dbo")
        {
        }

        public OugetSchInfoMap(string schema)
        {
            ToTable("OugetSchInfo", schema);
            HasKey(x => new { x.Doctorid, x.Locationid, x.SchRegTypeId, x.SchLimited, x.SchSegmented });

            Property(x => x.Doctorid).HasColumnName(@"doctorid").IsRequired().HasColumnType("int");
            Property(x => x.Locationid).HasColumnName(@"locationid").IsRequired().HasColumnType("int");
            Property(x => x.ShiftId).HasColumnName(@"shiftId").IsOptional().HasColumnType("int");
            Property(x => x.ShiftType).HasColumnName(@"shiftType").IsOptional().HasColumnType("int");
            Property(x => x.SchDate).HasColumnName(@"schDate").IsOptional().HasColumnType("datetime");
            Property(x => x.SchRegTypeId).HasColumnName(@"schRegTypeId").IsRequired().HasColumnType("int");
            Property(x => x.SchFee).HasColumnName(@"schFee").IsOptional().HasColumnType("decimal").HasPrecision(19,2);
            Property(x => x.SchRegfee).HasColumnName(@"schRegfee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SchTreatfee).HasColumnName(@"schTreatfee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SchBegintime).HasColumnName(@"schBegintime").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(8);
            Property(x => x.SchEndtime).HasColumnName(@"schEndtime").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(8);
            Property(x => x.SchRegMax).HasColumnName(@"schRegMax").IsOptional().HasColumnType("smallint");
            Property(x => x.SchRegCount).HasColumnName(@"schRegCount").IsOptional().HasColumnType("int");
            Property(x => x.SchLimited).HasColumnName(@"schLimited").IsRequired().HasColumnType("int");
            Property(x => x.SchSegmented).HasColumnName(@"schSegmented").IsRequired().HasColumnType("int");
            Property(x => x.Iscancel).HasColumnName(@"Iscancel").IsOptional().HasColumnType("int");
            Property(x => x.DiagRoom).HasColumnName(@"DiagRoom").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SpecialtyRoom).HasColumnName(@"SpecialtyRoom").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
