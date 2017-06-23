using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemListMap : EntityTypeConfiguration<BsItemList>
    {
        public BsItemListMap()
            : this("dbo")
        {
        }

        public BsItemListMap(string schema)
        {
            ToTable("BsItemList", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.IllName).HasColumnName(@"IllName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsOptional().HasColumnType("int");
            Property(x => x.PatientGroup).HasColumnName(@"PatientGroup").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.UnDrugId).HasColumnName(@"UnDrugId").IsOptional().HasColumnType("int");
            Property(x => x.UnDrugName).HasColumnName(@"UnDrugName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.TypeCode).HasColumnName(@"TypeCode").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsOptional().HasColumnType("int");
            Property(x => x.UnitName).HasColumnName(@"UnitName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.UsageName).HasColumnName(@"UsageName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyName).HasColumnName(@"FrequencyName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Quantity).HasColumnName(@"Quantity").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").IsOptional().HasColumnType("int");
            Property(x => x.WayCode).HasColumnName(@"WayCode").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Remark).HasColumnName(@"Remark").IsOptional().HasColumnType("nvarchar(max)");
            Property(x => x.ImpTime).HasColumnName(@"ImpTime").IsOptional().HasColumnType("datetime");
        }
    }
}
