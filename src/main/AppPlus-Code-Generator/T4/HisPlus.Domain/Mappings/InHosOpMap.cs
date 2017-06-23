using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InHosOpMap : EntityTypeConfiguration<InHosOp>
    {
        public InHosOpMap()
            : this("dbo")
        {
        }

        public InHosOpMap(string schema)
        {
            ToTable("InHosOps", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.OpsTimes).HasColumnName(@"OpsTimes").IsRequired().HasColumnType("int");
            Property(x => x.OpsTime).HasColumnName(@"OpsTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OpsId).HasColumnName(@"OpsId").IsOptional().HasColumnType("int");
            Property(x => x.LsCut).HasColumnName(@"LsCut").IsOptional().HasColumnType("smallint");
            Property(x => x.LsRecove).HasColumnName(@"LsRecove").IsOptional().HasColumnType("smallint");
            Property(x => x.OpsDoctorId).HasColumnName(@"OpsDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.AnaesId).HasColumnName(@"AnaesId").IsOptional().HasColumnType("int");
            Property(x => x.AssistantOperId1).HasColumnName(@"AssistantOperId1").IsOptional().HasColumnType("int");
            Property(x => x.AssistantOperId2).HasColumnName(@"AssistantOperId2").IsOptional().HasColumnType("int");
            Property(x => x.AnaesDoctorId).HasColumnName(@"AnaesDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
