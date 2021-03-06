using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InEmrMap : EntityTypeConfiguration<InEmr>
    {
        public InEmrMap()
            : this("dbo")
        {
        }

        public InEmrMap(string schema)
        {
            ToTable("InEMR", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.ModifyOperTime).HasColumnName(@"ModifyOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ModifyOperId).HasColumnName(@"ModifyOperID").IsOptional().HasColumnType("int");
            Property(x => x.CatalogId).HasColumnName(@"CatalogId").IsRequired().HasColumnType("int");
            Property(x => x.Content).HasColumnName(@"Content").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.XmlFile).HasColumnName(@"XMLFile").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsRequired().HasColumnType("bit");
            Property(x => x.AuthOperTime).HasColumnName(@"AuthOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.XmlContent).HasColumnName(@"XMLContent").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.IsRealease).HasColumnName(@"IsRealease").IsOptional().HasColumnType("bit");
            Property(x => x.RealeaseTime).HasColumnName(@"RealeaseTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.RealeaseOperId).HasColumnName(@"RealeaseOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsOptional().HasColumnType("bit");
            Property(x => x.PrintTime).HasColumnName(@"PrintTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PrintOperId).HasColumnName(@"PrintOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsClosed).HasColumnName(@"IsClosed").IsOptional().HasColumnType("bit");
            Property(x => x.ClosedTime).HasColumnName(@"ClosedTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ClosedOperId).HasColumnName(@"ClosedOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsCheck).HasColumnName(@"IsCheck").IsOptional().HasColumnType("bit");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.IsDelete).HasColumnName(@"IsDelete").IsOptional().HasColumnType("bit");
            Property(x => x.OperTime2).HasColumnName(@"OperTime2").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.NodeOrderBy).HasColumnName(@"NodeOrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.DeptName).HasColumnName(@"DeptName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.BedName).HasColumnName(@"BedName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.EmrTypeName).HasColumnName(@"EmrTypeName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
