using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsIllListMap : EntityTypeConfiguration<BsIllList>
    {
        public BsIllListMap()
            : this("dbo")
        {
        }

        public BsIllListMap(string schema)
        {
            ToTable("BsIllList", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.IllName).HasColumnName(@"IllName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsOptional().HasColumnType("int");
            Property(x => x.PatientGroup).HasColumnName(@"PatientGroup").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.UnDrugId).HasColumnName(@"UnDrugId").IsOptional().HasColumnType("int");
            Property(x => x.UnDrugName).HasColumnName(@"UnDrugName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.GroupOrder).HasColumnName(@"GroupOrder").IsOptional().HasColumnType("int");
            Property(x => x.UndrugOrder).HasColumnName(@"UndrugOrder").IsOptional().HasColumnType("int");
        }
    }
}
