using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblPatientMenuMap : EntityTypeConfiguration<GblPatientMenu>
    {
        public GblPatientMenuMap()
            : this("dbo")
        {
        }

        public GblPatientMenuMap(string schema)
        {
            ToTable("GblPatientMenu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LsType).HasColumnName(@"LsType").IsRequired().HasColumnType("smallint");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(40);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("int");
            Property(x => x.IsTitle).HasColumnName(@"IsTitle").IsRequired().HasColumnType("bit");
            Property(x => x.FormName).HasColumnName(@"FormName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TableName).HasColumnName(@"TableName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsForNew).HasColumnName(@"IsForNew").IsRequired().HasColumnType("bit");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsOptional().HasColumnType("bit");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsOptional().HasColumnType("bit");
            Property(x => x.SearchConfig).HasColumnName(@"SearchConfig").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
