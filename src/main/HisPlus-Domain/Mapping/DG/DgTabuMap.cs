using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgTabuMap : EntityTypeConfiguration<DgTabu>
    {
        public DgTabuMap()
            : this("dbo")
        {
        }

        public DgTabuMap(string schema)
        {
            ToTable("DgTabu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DrugId).HasColumnName(@"DrugID").IsRequired().HasColumnType("int");
            Property(x => x.DrugId1).HasColumnName(@"DrugID1").IsRequired().HasColumnType("int");
            Property(x => x.DrugId2).HasColumnName(@"DrugID2").IsOptional().HasColumnType("int");
            Property(x => x.DrugId3).HasColumnName(@"DrugID3").IsOptional().HasColumnType("int");
            Property(x => x.DrugId4).HasColumnName(@"DrugID4").IsOptional().HasColumnType("int");
            Property(x => x.LClass).HasColumnName(@"LClass").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Expain).HasColumnName(@"Expain").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
        }
    }
}
