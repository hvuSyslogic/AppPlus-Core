using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DhOuRecipeMap : EntityTypeConfiguration<DhOuRecipe>
    {
        public DhOuRecipeMap()
            : this("dbo")
        {
        }

        public DhOuRecipeMap(string schema)
        {
            ToTable("DhOuRecipe", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.RecId).HasColumnName(@"RecId").IsOptional().HasColumnType("int");
            Property(x => x.MzRegNo).HasColumnName(@"MzRegNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.RegTime).HasColumnName(@"RegTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Illness).HasColumnName(@"Illness").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.MedicareNo).HasColumnName(@"MedicareNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PatTypeName).HasColumnName(@"PatTypeName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.RegTypeName).HasColumnName(@"RegTypeName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.DiagnDeptName).HasColumnName(@"DiagnDeptName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.DoctorName).HasColumnName(@"DoctorName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.DoctorCode).HasColumnName(@"DoctorCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DocLevel).HasColumnName(@"DocLevel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RoomNo).HasColumnName(@"RoomNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsRepType).HasColumnName(@"LsRepType").IsOptional().HasColumnType("smallint");
            Property(x => x.RecipeNum).HasColumnName(@"RecipeNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.RecipeTime).HasColumnName(@"RecipeTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.HowMany).HasColumnName(@"HowMany").IsOptional().HasColumnType("smallint");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsOptional().HasColumnType("bit");
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IcdCode).HasColumnName(@"IcdCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
