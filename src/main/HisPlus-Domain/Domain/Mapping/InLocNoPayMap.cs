using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InLocNoPayMap : EntityTypeConfiguration<InLocNoPay>
    {
        public InLocNoPayMap()
            : this("dbo")
        {
        }

        public InLocNoPayMap(string schema)
        {
            ToTable("InLocNoPay", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsRequired().HasColumnType("datetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsRequired().HasColumnType("int");
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsRequired().HasColumnType("int");
            Property(x => x.LsInStatus).HasColumnName(@"LsInStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(38,2);
            Property(x => x.Opertime).HasColumnName(@"Opertime").IsRequired().HasColumnType("datetime");
        }
    }
}
