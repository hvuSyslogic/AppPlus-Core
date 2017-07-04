using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblInvRegMap : EntityTypeConfiguration<GblInvReg>
    {
        public GblInvRegMap()
            : this("dbo")
        {
        }

        public GblInvRegMap(string schema)
        {
            ToTable("GblInvReg", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvType).HasColumnName(@"InvType").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.StartInvoNo).HasColumnName(@"StartInvoNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.EndInvoNo).HasColumnName(@"EndInvoNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.IsEnd).HasColumnName(@"IsEnd").IsRequired().HasColumnType("bit");
            Property(x => x.EndTime).HasColumnName(@"EndTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
        }
    }
}
