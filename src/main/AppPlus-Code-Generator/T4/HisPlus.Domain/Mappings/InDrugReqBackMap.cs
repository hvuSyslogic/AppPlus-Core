using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDrugReqBackMap : EntityTypeConfiguration<InDrugReqBack>
    {
        public InDrugReqBackMap()
            : this("dbo")
        {
        }

        public InDrugReqBackMap(string schema)
        {
            ToTable("InDrugReqBack", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReqDtlId).HasColumnName(@"ReqDtlId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsBack).HasColumnName(@"IsBack").IsRequired().HasColumnType("bit");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.BackTime).HasColumnName(@"BackTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsOptional().HasColumnType("int");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsOptional().HasColumnType("smallint");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsOptional().HasColumnType("bit");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.RequestId).HasColumnName(@"RequestId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.BackOperId).HasColumnName(@"BackOperId").IsOptional().HasColumnType("int");
        }
    }
}
