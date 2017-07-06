using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsMessageTemplateMap : EntityTypeConfiguration<BsMessageTemplate>
    {
        public BsMessageTemplateMap()
            : this("dbo")
        {
        }

        public BsMessageTemplateMap(string schema)
        {
            ToTable("BsMessageTemplate", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Contents).HasColumnName(@"Contents").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.IsDefault).HasColumnName(@"IsDefault").IsOptional().HasColumnType("bit");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
        }
    }
}
