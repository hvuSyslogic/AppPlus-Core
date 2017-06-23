using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdBrainDeadMap : EntityTypeConfiguration<RdBrainDead>
    {
        public RdBrainDeadMap()
            : this("dbo")
        {
        }

        public RdBrainDeadMap(string schema)
        {
            ToTable("RdBrainDead", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IcdId).HasColumnName(@"ICDId").IsOptional().HasColumnType("int");
            Property(x => x.LsCardType).HasColumnName(@"LsCardType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCensus).HasColumnName(@"LsCensus").IsOptional().HasColumnType("smallint");
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.DiagDate).HasColumnName(@"DiagDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsIllBase).HasColumnName(@"LsIllBase").IsOptional().HasColumnType("smallint");
            Property(x => x.LsIllType).HasColumnName(@"LsIllType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IllDate).HasColumnName(@"IllDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsLastTime).HasColumnName(@"LsLastTime").IsOptional().HasColumnType("smallint");
            Property(x => x.IllTimes).HasColumnName(@"IllTimes").IsOptional().HasColumnType("int");
            Property(x => x.DeadDate).HasColumnName(@"DeadDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ImmediacyDead).HasColumnName(@"ImmediacyDead").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ElseIllness).HasColumnName(@"ElseIllness").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FormerlyIllness).HasColumnName(@"FormerlyIllness").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.YDiagDate).HasColumnName(@"YDiagDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DeadCause).HasColumnName(@"DeadCause").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.DeadIcd).HasColumnName(@"DeadICD").IsOptional().HasColumnType("int");
            Property(x => x.ElseIllnessIcd).HasColumnName(@"ElseIllnessICD").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.ReciOperId).HasColumnName(@"ReciOperId").IsOptional().HasColumnType("int");
            Property(x => x.ReportUnit).HasColumnName(@"ReportUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
