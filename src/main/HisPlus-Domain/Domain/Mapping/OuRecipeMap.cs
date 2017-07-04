using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuRecipeMap : EntityTypeConfiguration<OuRecipe>
    {
        public OuRecipeMap()
            : this("dbo")
        {
        }

        public OuRecipeMap(string schema)
        {
            ToTable("OuRecipe", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
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
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.IsDosage).HasColumnName(@"IsDosage").IsOptional().HasColumnType("bit");
            Property(x => x.DosageOperId).HasColumnName(@"DosageOperId").IsOptional().HasColumnType("int");
            Property(x => x.DosageTime).HasColumnName(@"DosageTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
        }
    }
}
