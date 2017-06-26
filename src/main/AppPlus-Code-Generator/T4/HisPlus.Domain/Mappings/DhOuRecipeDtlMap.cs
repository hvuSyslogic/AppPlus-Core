using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DhOuRecipeDtlMap : EntityTypeConfiguration<DhOuRecipeDtl>
    {
        public DhOuRecipeDtlMap()
            : this("dbo")
        {
        }

        public DhOuRecipeDtlMap(string schema)
        {
            ToTable("DhOuRecipeDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.ItemCode).HasColumnName(@"ItemCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsOptional().HasColumnType("smallint");
            Property(x => x.DrugName).HasColumnName(@"DrugName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Spec).HasColumnName(@"Spec").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FormName).HasColumnName(@"FormName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitDiagId).HasColumnName(@"UnitDiagId").IsOptional().HasColumnType("int");
            Property(x => x.IsAttach).HasColumnName(@"IsAttach").IsOptional().HasColumnType("bit");
            Property(x => x.IsSelf).HasColumnName(@"IsSelf").IsOptional().HasColumnType("bit");
            Property(x => x.IsSkin).HasColumnName(@"IsSkin").IsOptional().HasColumnType("bit");
            Property(x => x.SkinTime).HasColumnName(@"SkinTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SkinTest).HasColumnName(@"SkinTest").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperName).HasColumnName(@"OperName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AuthTime).HasColumnName(@"AuthTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthName).HasColumnName(@"AuthName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsExec).HasColumnName(@"IsExec").IsOptional().HasColumnType("bit");
            Property(x => x.ExecTime).HasColumnName(@"ExecTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ExecOperName).HasColumnName(@"ExecOperName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
