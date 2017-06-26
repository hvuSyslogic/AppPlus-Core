using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InOpsSumMap : EntityTypeConfiguration<InOpsSum>
    {
        public InOpsSumMap()
            : this("dbo")
        {
        }

        public InOpsSumMap(string schema)
        {
            ToTable("InOpsSum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.SelectDateNum).HasColumnName(@"SelectDateNum").IsRequired().HasColumnType("int");
            Property(x => x.EmergencyNum).HasColumnName(@"EmergencyNum").IsRequired().HasColumnType("int");
            Property(x => x.OutPatientNum).HasColumnName(@"OutPatientNum").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
