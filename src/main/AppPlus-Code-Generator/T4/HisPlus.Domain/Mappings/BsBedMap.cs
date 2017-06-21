using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBedMap : EntityTypeConfiguration<BsBed>
    {
        public BsBedMap()
            : this("dbo")
        {
        }

        public BsBedMap(string schema)
        {
            ToTable("BsBed", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.RoomNo).HasColumnName(@"RoomNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.LsBall).HasColumnName(@"LsBALL").IsRequired().HasColumnType("smallint");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.IsAdd).HasColumnName(@"IsAdd").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.LsClass).HasColumnName(@"LsClass").IsRequired().HasColumnType("smallint");
            Property(x => x.IsAddBed).HasColumnName(@"IsAddBed").IsOptional().HasColumnType("bit");
        }
    }
}
