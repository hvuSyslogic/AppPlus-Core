using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InChangeBedMap : EntityTypeConfiguration<InChangeBed>
    {
        public InChangeBedMap()
            : this("dbo")
        {
        }

        public InChangeBedMap(string schema)
        {
            ToTable("InChangeBed", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.LsLocal).HasColumnName(@"LsLocal").IsRequired().HasColumnType("smallint");
            Property(x => x.ChgTime).HasColumnName(@"ChgTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PreBed).HasColumnName(@"PreBed").IsRequired().HasColumnType("int");
            Property(x => x.PostBed).HasColumnName(@"PostBed").IsRequired().HasColumnType("int");
            Property(x => x.Reason).HasColumnName(@"Reason").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
