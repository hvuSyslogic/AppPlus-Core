using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatTypeMap : EntityTypeConfiguration<BsPatType>
    {
        public BsPatTypeMap()
            : this("dbo")
        {
        }

        public BsPatTypeMap(string schema)
        {
            ToTable("BsPatType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LimitFee).HasColumnName(@"LimitFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LimitIn).HasColumnName(@"LimitIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ArrearFei).HasColumnName(@"ArrearFei").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DiscDiag).HasColumnName(@"DiscDiag").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.DiscIn).HasColumnName(@"DiscIn").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.HeadNo).HasColumnName(@"HeadNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TallyTypeId).HasColumnName(@"TallyTypeId").IsRequired().HasColumnType("int");
            Property(x => x.ArrearAmount).HasColumnName(@"ArrearAmount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LsGfPatType).HasColumnName(@"LsGFPatType").IsOptional().HasColumnType("smallint");
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.TwoDiscIn1).HasColumnName(@"TwoDiscIn1").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.TwoDiscIn2).HasColumnName(@"TwoDiscIn2").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
        }
    }
}
