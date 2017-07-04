using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemBpIdMap : EntityTypeConfiguration<BsItemBpId>
    {
        public BsItemBpIdMap()
            : this("dbo")
        {
        }

        public BsItemBpIdMap(string schema)
        {
            ToTable("BsItemBPId", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BpItemId).HasColumnName(@"BPItemId").IsOptional().HasColumnType("int");
            Property(x => x.HisItemId).HasColumnName(@"HISItemId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.UserId).HasColumnName(@"UserId").IsOptional().HasColumnType("int");
        }
    }
}
