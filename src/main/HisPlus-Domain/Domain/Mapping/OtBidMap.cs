using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OtBidMap : EntityTypeConfiguration<OtBid>
    {
        public OtBidMap()
            : this("dbo")
        {
        }

        public OtBidMap(string schema)
        {
            ToTable("OtBid", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.BitTime).HasColumnName(@"BitTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.NotifyDate).HasColumnName(@"NotifyDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DispUnit).HasColumnName(@"DispUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.SignTime).HasColumnName(@"SignTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SignOperId).HasColumnName(@"SignOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsOptional().HasColumnType("bit");
        }
    }
}
