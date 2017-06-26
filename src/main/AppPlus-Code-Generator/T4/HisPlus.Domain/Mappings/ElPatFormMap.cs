using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPatFormMap : EntityTypeConfiguration<ElPatForm>
    {
        public ElPatFormMap()
            : this("dbo")
        {
        }

        public ElPatFormMap(string schema)
        {
            ToTable("ElPatForm", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.PatMenuId).HasColumnName(@"PatMenuId").IsRequired().HasColumnType("int");
            Property(x => x.RecId).HasColumnName(@"RecId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsOptional().HasColumnType("bit");
            Property(x => x.AuthTime).HasColumnName(@"AuthTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.RejectReason).HasColumnName(@"RejectReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.InActiveReason).HasColumnName(@"InActiveReason").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InActiveTime).HasColumnName(@"InActiveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InActiveOperId).HasColumnName(@"InActiveOperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
