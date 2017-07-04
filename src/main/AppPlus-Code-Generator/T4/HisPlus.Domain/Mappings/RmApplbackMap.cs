using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmApplbackMap : EntityTypeConfiguration<RmApplback>
    {
        public RmApplbackMap()
            : this("dbo")
        {
        }

        public RmApplbackMap(string schema)
        {
            ToTable("RmApplback", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsAffirm).HasColumnName(@"IsAffirm").IsRequired().HasColumnType("bit");
            Property(x => x.AffirmTime).HasColumnName(@"AffirmTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AffirmOperid).HasColumnName(@"AffirmOperid").IsOptional().HasColumnType("int");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsRequired().HasColumnType("bit");
            Property(x => x.SignTime).HasColumnName(@"SignTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SignOperId).HasColumnName(@"SignOperId").IsOptional().HasColumnType("int");
            Property(x => x.CkBillNo).HasColumnName(@"CkBillNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
        }
    }
}
