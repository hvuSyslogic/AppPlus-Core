namespace HisPlus.Domain.Mapping
{
    using HisPlus.Domain;
    using System.Data.Entity.ModelConfiguration;

    public class BsLabSourceItem0510Map : EntityTypeConfiguration<BsLabSourceItem0510>
    {
        public BsLabSourceItem0510Map()
            : this("dbo")
        {
        }

        public BsLabSourceItem0510Map(string schema)
        {
            ToTable("BsLabSourceItem_0510", schema);
            HasKey(x => new { x.Id, x.SourceId, x.ItemId, x.Totality, x.LsUseArea });

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int");
            Property(x => x.SourceId).HasColumnName(@"SourceId").IsRequired().HasColumnType("int");
            Property(x => x.TubeTypeId).HasColumnName(@"TubeTypeId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.LsUseArea).HasColumnName(@"LsUseArea").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
