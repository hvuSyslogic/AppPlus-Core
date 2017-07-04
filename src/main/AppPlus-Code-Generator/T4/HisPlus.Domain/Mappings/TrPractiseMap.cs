using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TrPractiseMap : EntityTypeConfiguration<TrPractise>
    {
        public TrPractiseMap()
            : this("dbo")
        {
        }

        public TrPractiseMap(string schema)
        {
            ToTable("TrPractise", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Hospital).HasColumnName(@"Hospital").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OriId).HasColumnName(@"OriId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.PractiseTime).HasColumnName(@"PractiseTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DebugMode).HasColumnName(@"DebugMode").IsOptional().HasColumnType("tinyint");
            Property(x => x.Funtion).HasColumnName(@"Funtion").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UserName).HasColumnName(@"UserName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RoleName).HasColumnName(@"RoleName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LocationName).HasColumnName(@"LocationName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
