using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RtrjkreportMap : EntityTypeConfiguration<Rtrjkreport>
    {
        public RtrjkreportMap()
            : this("dbo")
        {
        }

        public RtrjkreportMap(string schema)
        {
            ToTable("RTRJKREPORT", schema);
            HasKey(x => new { x.Id, x.Operid, x.Opertime, x.IsSign });

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Operid).HasColumnName(@"operid").IsRequired().HasColumnType("int");
            Property(x => x.Opertime).HasColumnName(@"opertime").IsRequired().HasColumnType("datetime");
            Property(x => x.Cancelopertime).HasColumnName(@"cancelopertime").IsOptional().HasColumnType("datetime");
            Property(x => x.Iscancel).HasColumnName(@"iscancel").IsOptional().HasColumnType("int");
            Property(x => x.Begintime).HasColumnName(@"begintime").IsOptional().HasColumnType("datetime");
            Property(x => x.Endtime).HasColumnName(@"endtime").IsOptional().HasColumnType("datetime");
            Property(x => x.Hospitalid).HasColumnName(@"hospitalid").IsOptional().HasColumnType("int");
            Property(x => x.LsOutIn).HasColumnName(@"LsOutIn").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Bills).HasColumnName(@"bills").IsOptional().HasColumnType("int");
            Property(x => x.Billcancel).HasColumnName(@"billcancel").IsOptional().HasColumnType("int");
            Property(x => x.AmountSum).HasColumnName(@"AmountSum").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.AmountCancel).HasColumnName(@"AmountCancel").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Insurance).HasColumnName(@"Insurance").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.AmountYf).HasColumnName(@"AmountYF").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsRequired().HasColumnType("bit");
            Property(x => x.SignTime).HasColumnName(@"SignTime").IsOptional().HasColumnType("datetime");
            Property(x => x.SignOperId).HasColumnName(@"SignOperId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(4000);
        }
    }
}
