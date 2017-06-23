using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmGroupPrintNumMap : EntityTypeConfiguration<RmGroupPrintNum>
    {
        public RmGroupPrintNumMap()
            : this("dbo")
        {
        }

        public RmGroupPrintNumMap(string schema)
        {
            ToTable("RmGroupPrintNum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PrintDate).HasColumnName(@"PrintDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Group1PageNum).HasColumnName(@"Group1PageNum").IsOptional().HasColumnType("int");
            Property(x => x.Group2PageNum).HasColumnName(@"Group2PageNum").IsOptional().HasColumnType("int");
            Property(x => x.Group3PageNum).HasColumnName(@"Group3PageNum").IsOptional().HasColumnType("int");
            Property(x => x.Group4PageNum).HasColumnName(@"Group4PageNum").IsOptional().HasColumnType("int");
            Property(x => x.Group5PageNum).HasColumnName(@"Group5PageNum").IsOptional().HasColumnType("int");
            Property(x => x.Group6PageNum).HasColumnName(@"Group6PageNum").IsOptional().HasColumnType("int");
            Property(x => x.PreviousGroup1PageNum).HasColumnName(@"PreviousGroup1PageNum").IsOptional().HasColumnType("int");
            Property(x => x.PreviousGroup2PageNum).HasColumnName(@"PreviousGroup2PageNum").IsOptional().HasColumnType("int");
            Property(x => x.PreviousGroup3PageNum).HasColumnName(@"PreviousGroup3PageNum").IsOptional().HasColumnType("int");
            Property(x => x.PreviousGroup4PageNum).HasColumnName(@"PreviousGroup4PageNum").IsOptional().HasColumnType("int");
            Property(x => x.PreviousGroup5PageNum).HasColumnName(@"PreviousGroup5PageNum").IsOptional().HasColumnType("int");
            Property(x => x.PreviousGroup6PageNum).HasColumnName(@"PreviousGroup6PageNum").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
