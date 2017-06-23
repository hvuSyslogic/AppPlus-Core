using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InChinRicipeMap : EntityTypeConfiguration<InChinRicipe>
    {
        public InChinRicipeMap()
            : this("dbo")
        {
        }

        public InChinRicipeMap(string schema)
        {
            ToTable("InChinRicipe", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecipeNo).HasColumnName(@"RecipeNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("smallint");
            Property(x => x.DecoctNum).HasColumnName(@"DecoctNum").IsRequired().HasColumnType("smallint");
            Property(x => x.IsConfirm).HasColumnName(@"IsConfirm").IsRequired().HasColumnType("bit");
            Property(x => x.LsCookSelf).HasColumnName(@"LsCookSelf").IsRequired().HasColumnType("smallint");
            Property(x => x.ConfirmOperId).HasColumnName(@"ConfirmOperID").IsOptional().HasColumnType("int");
            Property(x => x.ConfirmOperTime).HasColumnName(@"ConfirmOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsBack).HasColumnName(@"IsBack").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsOptional().HasColumnType("bit");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsOptional().HasColumnType("bit");
            Property(x => x.BackTime).HasColumnName(@"BackTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CookMinute).HasColumnName(@"CookMinute").IsOptional().HasColumnType("smallint");
            Property(x => x.LsFire).HasColumnName(@"LsFire").IsOptional().HasColumnType("smallint");
            Property(x => x.AdviceLocationId).HasColumnName(@"AdviceLocationId").IsOptional().HasColumnType("int");
        }
    }
}
