using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class FtMainMap : EntityTypeConfiguration<FtMain>
    {
        public FtMainMap()
            : this("dbo")
        {
        }

        public FtMainMap(string schema)
        {
            ToTable("FtMain", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CheckNo).HasColumnName(@"CheckNo").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.UserId).HasColumnName(@"UserId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsOptional().HasColumnType("bit");
            Property(x => x.IsConfirm).HasColumnName(@"IsConfirm").IsRequired().HasColumnType("bit");
            Property(x => x.ConfirmOperTime).HasColumnName(@"ConfirmOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ConfirmOperId).HasColumnName(@"ConfirmOperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
