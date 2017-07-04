using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemIllTypeMap : EntityTypeConfiguration<BsItemIllType>
    {
        public BsItemIllTypeMap()
            : this("dbo")
        {
        }

        public BsItemIllTypeMap(string schema)
        {
            ToTable("BsItemIllType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.IllTypeId).HasColumnName(@"IllTypeId").IsRequired().HasColumnType("int");
            Property(x => x.YbCode).HasColumnName(@"YbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.TallyGroupId).HasColumnName(@"TallyGroupId").IsOptional().HasColumnType("int");
        }
    }
}
