using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuDiagCallMap : EntityTypeConfiguration<OuDiagCall>
    {
        public OuDiagCallMap()
            : this("dbo")
        {
        }

        public OuDiagCallMap(string schema)
        {
            ToTable("OuDiagCall", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PatName).HasColumnName(@"PatName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ActType).HasColumnName(@"ActType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsCall).HasColumnName(@"IsCall").IsOptional().HasColumnType("bit");
        }
    }
}
