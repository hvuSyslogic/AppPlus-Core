using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkQcResultMap : EntityTypeConfiguration<CkQcResult>
    {
        public CkQcResultMap()
            : this("dbo")
        {
        }

        public CkQcResultMap(string schema)
        {
            ToTable("CkQcResult", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ResultDate).HasColumnName(@"ResultDate").IsRequired().HasColumnType("datetime");
            Property(x => x.Result).HasColumnName(@"Result").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ResultComment).HasColumnName(@"ResultComment").IsRequired().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.ResultStatus).HasColumnName(@"ResultStatus").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(2);
            Property(x => x.LotId).HasColumnName(@"LotId").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.CtrlId).HasColumnName(@"CtrlId").IsRequired().HasColumnType("int");
            Property(x => x.IsShowQc).HasColumnName(@"IsShowQc").IsOptional().HasColumnType("bit");
            Property(x => x.RejectMemo).HasColumnName(@"RejectMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
