using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuBackMap : EntityTypeConfiguration<HuBack>
    {
        public HuBackMap()
            : this("dbo")
        {
        }

        public HuBackMap(string schema)
        {
            ToTable("HuBack", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsRequired().HasColumnType("bit");
            Property(x => x.SignTime).HasColumnName(@"SignTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SignOperId).HasColumnName(@"SignOperId").IsOptional().HasColumnType("int");
            Property(x => x.RkBillNo).HasColumnName(@"RkBillNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
        }
    }
}
