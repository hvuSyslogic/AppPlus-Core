using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuExecuteBackMap : EntityTypeConfiguration<OuExecuteBack>
    {
        public OuExecuteBackMap()
            : this("dbo")
        {
        }

        public OuExecuteBackMap(string schema)
        {
            ToTable("OuExecuteBack", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsRequired().HasColumnType("int");
            Property(x => x.ExecuteDtlId).HasColumnName(@"ExecuteDtlId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsBack).HasColumnName(@"IsBack").IsRequired().HasColumnType("bit");
            Property(x => x.KsBackBillId).HasColumnName(@"KsBackBillId").IsOptional().HasColumnType("int");
            Property(x => x.BackTime).HasColumnName(@"BackTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
