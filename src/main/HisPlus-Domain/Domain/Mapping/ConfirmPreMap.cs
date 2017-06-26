using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ConfirmPreMap : EntityTypeConfiguration<ConfirmPre>
    {
        public ConfirmPreMap()
            : this("dbo")
        {
        }

        public ConfirmPreMap(string schema)
        {
            ToTable("ConfirmPres", schema);
            HasKey(x => x.Id);

            Property(x => x.Presno).HasColumnName(@"Presno").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PresDate).HasColumnName(@"PresDate").IsRequired().HasColumnType("date");
            Property(x => x.WindowNo).HasColumnName(@"WindowNO").IsRequired().HasColumnType("int");
            Property(x => x.PatientId).HasColumnName(@"PatientID").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Flag).HasColumnName(@"Flag").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Fpno).HasColumnName(@"FPNO").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
