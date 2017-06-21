using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsScoreMap : EntityTypeConfiguration<BsScore>
    {
        public BsScoreMap()
            : this("dbo")
        {
        }

        public BsScoreMap(string schema)
        {
            ToTable("BsScore", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
            Property(x => x.TestPaperId).HasColumnName(@"TestPaperId").IsRequired().HasColumnType("int");
            Property(x => x.Score).HasColumnName(@"Score").IsRequired().HasColumnType("int");
            Property(x => x.Answer).HasColumnName(@"Answer").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
