using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuFeeArrearMap : EntityTypeConfiguration<OuFeeArrear>
    {
        public OuFeeArrearMap()
            : this("dbo")
        {
        }

        public OuFeeArrearMap(string schema)
        {
            ToTable("OuFeeArrears", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,5);
            Property(x => x.IsPay).HasColumnName(@"IsPay").IsOptional().HasColumnType("bit");
            Property(x => x.PayTime).HasColumnName(@"PayTime").IsOptional().HasColumnType("datetime");
        }
    }
}
