using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkItemMap : EntityTypeConfiguration<CkItem>
    {
        public CkItemMap()
            : this("dbo")
        {
        }

        public CkItemMap(string schema)
        {
            ToTable("CkItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsTestType).HasColumnName(@"LsTestType").IsRequired().HasColumnType("smallint");
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeId").IsOptional().HasColumnType("int");
            Property(x => x.TubeTypeId).HasColumnName(@"TubeTypeId").IsOptional().HasColumnType("int");
            Property(x => x.ShortName).HasColumnName(@"ShortName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperMemo).HasColumnName(@"OperMemo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsZero).HasColumnName(@"IsZero").IsRequired().HasColumnType("bit");
            Property(x => x.LsGroup).HasColumnName(@"LsGroup").IsRequired().HasColumnType("smallint");
            Property(x => x.IsReport).HasColumnName(@"IsReport").IsRequired().HasColumnType("bit");
            Property(x => x.UseRange).HasColumnName(@"UseRange").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.LsForSex).HasColumnName(@"LsForSex").IsRequired().HasColumnType("smallint");
            Property(x => x.SourceId).HasColumnName(@"SourceId").IsOptional().HasColumnType("int");
            Property(x => x.Price).HasColumnName(@"Price").IsRequired().HasColumnType("decimal").HasPrecision(12,2);
            Property(x => x.Unit).HasColumnName(@"Unit").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Format).HasColumnName(@"Format").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LimitHigh).HasColumnName(@"LimitHigh").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LimitLow).HasColumnName(@"LimitLow").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PrintHigh).HasColumnName(@"PrintHigh").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PrintLow).HasColumnName(@"PrintLow").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DalAbsolute).HasColumnName(@"DalAbsolute").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DalPercent).HasColumnName(@"DalPercent").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsDisplay).HasColumnName(@"IsDisplay").IsRequired().HasColumnType("bit");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FluidId).HasColumnName(@"FluidId").IsOptional().HasColumnType("int");
            Property(x => x.TestWay).HasColumnName(@"TestWay").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Dev3).HasColumnName(@"Dev3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Dev2).HasColumnName(@"Dev2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Dev1).HasColumnName(@"Dev1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DevM1).HasColumnName(@"DevM1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DevM2).HasColumnName(@"DevM2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DevM3).HasColumnName(@"DevM3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AvgValue).HasColumnName(@"AvgValue").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DefultValue).HasColumnName(@"DefultValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
