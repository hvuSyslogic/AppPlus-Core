using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkBldReactionMap : EntityTypeConfiguration<CkBldReaction>
    {
        public CkBldReactionMap()
            : this("dbo")
        {
        }

        public CkBldReactionMap(string schema)
        {
            ToTable("CkBldReaction", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.LabId).HasColumnName(@"LabId").IsRequired().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.BloodId).HasColumnName(@"BloodId").IsRequired().HasColumnType("int");
            Property(x => x.TransTime).HasColumnName(@"TransTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.TransType).HasColumnName(@"TransType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TotalVollume).HasColumnName(@"TotalVollume").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ReactTime).HasColumnName(@"ReactTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsTransType).HasColumnName(@"LsTransType").IsOptional().HasColumnType("smallint");
            Property(x => x.ClincHandle).HasColumnName(@"ClincHandle").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.TransHandle).HasColumnName(@"TransHandle").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
        }
    }
}
