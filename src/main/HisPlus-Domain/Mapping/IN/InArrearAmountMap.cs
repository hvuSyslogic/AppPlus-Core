using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InArrearAmountMap : EntityTypeConfiguration<InArrearAmount>
    {
        public InArrearAmountMap()
            : this("dbo")
        {
        }

        public InArrearAmountMap(string schema)
        {
            ToTable("InArrearAmount", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.ArrearAmount).HasColumnName(@"ArrearAmount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AuthMan).HasColumnName(@"AuthMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ExpireDate).HasColumnName(@"ExpireDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ExpireHours).HasColumnName(@"ExpireHours").IsOptional().HasColumnType("smallint");
            Property(x => x.IsMax).HasColumnName(@"IsMax").IsOptional().HasColumnType("bit");
        }
    }
}
