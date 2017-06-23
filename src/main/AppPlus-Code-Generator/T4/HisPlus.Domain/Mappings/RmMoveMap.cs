using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmMoveMap : EntityTypeConfiguration<RmMove>
    {
        public RmMoveMap()
            : this("dbo")
        {
        }

        public RmMoveMap(string schema)
        {
            ToTable("RmMove", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.RoomIdI).HasColumnName(@"RoomIdI").IsRequired().HasColumnType("int");
            Property(x => x.RoomIdO).HasColumnName(@"RoomIdO").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Operid).HasColumnName(@"Operid").IsRequired().HasColumnType("int");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsRequired().HasColumnType("bit");
            Property(x => x.SignTime).HasColumnName(@"SignTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SignOperId).HasColumnName(@"SignOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsSignRev).HasColumnName(@"IsSignRev").IsOptional().HasColumnType("bit");
            Property(x => x.SignTimeRev).HasColumnName(@"SignTimeRev").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SignOperIdRev).HasColumnName(@"SignOperIdRev").IsOptional().HasColumnType("int");
        }
    }
}
