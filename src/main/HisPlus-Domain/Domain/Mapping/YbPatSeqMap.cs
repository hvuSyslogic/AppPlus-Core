using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class YbPatSeqMap : EntityTypeConfiguration<YbPatSeq>
    {
        public YbPatSeqMap()
            : this("dbo")
        {
        }

        public YbPatSeqMap(string schema)
        {
            ToTable("YbPatSeq", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.YbSeq).HasColumnName(@"YbSeq").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
