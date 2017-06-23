using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InEmrSignMap : EntityTypeConfiguration<InEmrSign>
    {
        public InEmrSignMap()
            : this("dbo")
        {
        }

        public InEmrSignMap(string schema)
        {
            ToTable("InEmrSign", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.EmrId).HasColumnName(@"EmrId").IsOptional().HasColumnType("int");
            Property(x => x.SignValue).HasColumnName(@"SignValue").IsOptional().HasColumnType("nvarchar(max)");
            Property(x => x.SignDate).HasColumnName(@"SignDate").IsOptional().HasColumnType("datetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
