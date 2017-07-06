using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuRecipeTempMap : EntityTypeConfiguration<OuRecipeTemp>
    {
        public OuRecipeTempMap()
            : this("dbo")
        {
        }

        public OuRecipeTempMap(string schema)
        {
            ToTable("OuRecipeTemp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsRequired().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.MzRegNo).HasColumnName(@"MzRegNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.RegTime).HasColumnName(@"RegTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Age).HasColumnName(@"Age").IsOptional().HasColumnType("smallint");
            Property(x => x.BabyMonth).HasColumnName(@"BabyMonth").IsOptional().HasColumnType("smallint");
            Property(x => x.AddressHome).HasColumnName(@"AddressHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.LsRepType).HasColumnName(@"LsRepType").IsRequired().HasColumnType("smallint");
            Property(x => x.RecipeNum).HasColumnName(@"RecipeNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.RecipeTime).HasColumnName(@"RecipeTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.HowMany).HasColumnName(@"HowMany").IsOptional().HasColumnType("smallint");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsPend).HasColumnName(@"IsPend").IsRequired().HasColumnType("bit");
            Property(x => x.IsExecuted).HasColumnName(@"IsExecuted").IsRequired().HasColumnType("bit");
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.ContactPhone).HasColumnName(@"ContactPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PyCode1).HasColumnName(@"PyCode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.WbCode1).HasColumnName(@"WbCode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.PyCode2).HasColumnName(@"PyCode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.WbCode2).HasColumnName(@"WbCode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.PyCode3).HasColumnName(@"PyCode3").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.WbCode3).HasColumnName(@"WbCode3").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DoctorName).HasColumnName(@"DoctorName").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LocationName).HasColumnName(@"LocationName").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsRequired().HasColumnType("int");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.IsIssue).HasColumnName(@"IsIssue").IsRequired().HasColumnType("bit");
            Property(x => x.IsBack).HasColumnName(@"IsBack").IsRequired().HasColumnType("bit");
            Property(x => x.RoomWindowName).HasColumnName(@"RoomWindowName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsReportType).HasColumnName(@"LsReportType").IsOptional().HasColumnType("int");
            Property(x => x.DosageOperId).HasColumnName(@"DosageOperId").IsOptional().HasColumnType("int");
            Property(x => x.DosageTime).HasColumnName(@"DosageTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
        }
    }
}
