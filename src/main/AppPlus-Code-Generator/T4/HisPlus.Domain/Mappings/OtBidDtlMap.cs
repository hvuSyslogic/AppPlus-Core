using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OtBidDtlMap : EntityTypeConfiguration<OtBidDtl>
    {
        public OtBidDtlMap()
            : this("dbo")
        {
        }

        public OtBidDtlMap(string schema)
        {
            ToTable("OtBidDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BidId).HasColumnName(@"BidId").IsOptional().HasColumnType("int");
            Property(x => x.RoundNTime).HasColumnName(@"RoundNTime").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.ExpOperId).HasColumnName(@"ExpOperId").IsRequired().HasColumnType("int");
            Property(x => x.Point).HasColumnName(@"Point").IsOptional().HasColumnType("tinyint");
            Property(x => x.IsPass).HasColumnName(@"IsPass").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
