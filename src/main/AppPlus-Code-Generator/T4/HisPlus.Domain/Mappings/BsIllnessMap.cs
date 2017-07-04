using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsIllnessMap : EntityTypeConfiguration<BsIllness>
    {
        public BsIllnessMap()
            : this("dbo")
        {
        }

        public BsIllnessMap(string schema)
        {
            ToTable("BsIllness", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.OtherCode).HasColumnName(@"OtherCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.OtherDesc).HasColumnName(@"OtherDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.GroupMain).HasColumnName(@"GroupMain").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupSub).HasColumnName(@"GroupSub").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupSSub).HasColumnName(@"GroupSSub").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BelongIcd).HasColumnName(@"BelongIcd").IsOptional().HasColumnType("int");
            Property(x => x.IsSum).HasColumnName(@"IsSum").IsRequired().HasColumnType("bit");
            Property(x => x.FeeHigh).HasColumnName(@"FeeHigh").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DayHigh).HasColumnName(@"DayHigh").IsOptional().HasColumnType("smallint");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.IsInfectious).HasColumnName(@"IsInfectious").IsOptional().HasColumnType("bit");
        }
    }
}
