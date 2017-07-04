using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkBloodSendMap : EntityTypeConfiguration<CkBloodSend>
    {
        public CkBloodSendMap()
            : this("dbo")
        {
        }

        public CkBloodSendMap(string schema)
        {
            ToTable("CkBloodSend", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.LabId).HasColumnName(@"LabId").IsRequired().HasColumnType("int");
            Property(x => x.BloodId).HasColumnName(@"BloodId").IsRequired().HasColumnType("int");
            Property(x => x.NoteTime).HasColumnName(@"NoteTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.NoteOperId).HasColumnName(@"NoteOperId").IsRequired().HasColumnType("int");
            Property(x => x.IsSend).HasColumnName(@"IsSend").IsOptional().HasColumnType("bit");
            Property(x => x.SendTime).HasColumnName(@"SendTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SendOperId).HasColumnName(@"SendOperId").IsOptional().HasColumnType("int");
            Property(x => x.TakeMan).HasColumnName(@"TakeMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
        }
    }
}
