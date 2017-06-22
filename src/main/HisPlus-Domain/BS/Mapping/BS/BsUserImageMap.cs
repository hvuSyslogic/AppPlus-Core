namespace HisPlus.Domain.Mapping
{
    using HisPlus.Domain;
    using System.Data.Entity.ModelConfiguration;

    public class BsUserImageMap : EntityTypeConfiguration<BsUserImage>
    {
        public BsUserImageMap()
            : this("dbo")
        {
        }

        public BsUserImageMap(string schema)
        {
            ToTable("BsUserImage", schema);
            HasKey(x => new { x.Id, x.UserId, x.UserImage });

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.UserImage).HasColumnName(@"UserImage").IsRequired().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
