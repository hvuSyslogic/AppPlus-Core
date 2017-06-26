using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgDrugTipMap : EntityTypeConfiguration<DgDrugTip>
    {
        public DgDrugTipMap()
            : this("dbo")
        {
        }

        public DgDrugTipMap(string schema)
        {
            ToTable("DgDrugTip", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DrugId).HasColumnName(@"DrugID").IsRequired().HasColumnType("int");
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.AgeFrom).HasColumnName(@"AgeFrom").IsRequired().HasColumnType("int");
            Property(x => x.AgeTo).HasColumnName(@"AgeTo").IsRequired().HasColumnType("int");
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.WorktypeId).HasColumnName(@"WorktypeId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.LsWomenStatus).HasColumnName(@"LsWomenStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.DropSpeed).HasColumnName(@"DropSpeed").IsOptional().HasColumnType("int");
            Property(x => x.LClass).HasColumnName(@"LClass").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Expain).HasColumnName(@"Expain").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
        }
    }
}
