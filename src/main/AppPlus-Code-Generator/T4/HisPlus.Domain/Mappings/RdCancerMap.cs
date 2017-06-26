using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdCancerMap : EntityTypeConfiguration<RdCancer>
    {
        public RdCancerMap()
            : this("dbo")
        {
        }

        public RdCancerMap(string schema)
        {
            ToTable("RdCancer", schema);
            HasKey(x => x.Id);

            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsCardType).HasColumnName(@"LsCardType").IsOptional().HasColumnType("int");
            Property(x => x.LsCensus).HasColumnName(@"LsCensus").IsOptional().HasColumnType("int");
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.LsIllBase).HasColumnName(@"LsIllBase").IsOptional().HasColumnType("int");
            Property(x => x.DiagDate).HasColumnName(@"DiagDate").IsOptional().HasColumnType("datetime");
            Property(x => x.PathologyType).HasColumnName(@"PathologyType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FormerlyIllness).HasColumnName(@"FormerlyIllness").IsOptional().HasColumnType("int");
            Property(x => x.YDiagDate).HasColumnName(@"YDiagDate").IsOptional().HasColumnType("datetime");
            Property(x => x.DeadDate).HasColumnName(@"DeadDate").IsOptional().HasColumnType("datetime");
            Property(x => x.DeadCause).HasColumnName(@"DeadCause").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IcdId).HasColumnName(@"ICDId").IsOptional().HasColumnType("int");
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(40);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(40);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(40);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(40);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReciOperId).HasColumnName(@"ReciOperId").IsOptional().HasColumnType("int");
            Property(x => x.ReportUnit).HasColumnName(@"ReportUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsOptional().HasColumnType("datetime");
        }
    }
}
