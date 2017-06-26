using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsSpecialtyRoomMap : EntityTypeConfiguration<BsSpecialtyRoom>
    {
        public BsSpecialtyRoomMap()
            : this("dbo")
        {
        }

        public BsSpecialtyRoomMap(string schema)
        {
            ToTable("BsSpecialtyRoom", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"CODE").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"NAME").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Hospitalid).HasColumnName(@"HOSPITALID").IsOptional().HasColumnType("int");
            Property(x => x.Locationid).HasColumnName(@"LOCATIONID").IsOptional().HasColumnType("int");
            Property(x => x.Wbcode).HasColumnName(@"WBCODE").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Pycode).HasColumnName(@"PYCODE").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Orderby).HasColumnName(@"ORDERBY").IsRequired().HasColumnType("int");
            Property(x => x.Isactive).HasColumnName(@"ISACTIVE").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Iconindex).HasColumnName(@"ICONINDEX").IsRequired().HasColumnType("int");
        }
    }
}
