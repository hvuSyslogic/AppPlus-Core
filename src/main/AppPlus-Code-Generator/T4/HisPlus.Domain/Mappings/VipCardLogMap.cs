using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipCardLogMap : EntityTypeConfiguration<VipCardLog>
    {
        public VipCardLogMap()
            : this("dbo")
        {
        }

        public VipCardLogMap(string schema)
        {
            ToTable("VipCardLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VipCardId).HasColumnName(@"VipCardId").IsOptional().HasColumnType("int");
            Property(x => x.OldCardNo).HasColumnName(@"OldCardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NewCardNo).HasColumnName(@"NewCardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("date");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
        }
    }
}
