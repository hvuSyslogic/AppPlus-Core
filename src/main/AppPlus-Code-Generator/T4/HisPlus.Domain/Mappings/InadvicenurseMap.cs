using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InadvicenurseMap : EntityTypeConfiguration<Inadvicenurse>
    {
        public InadvicenurseMap()
            : this("dbo")
        {
        }

        public InadvicenurseMap(string schema)
        {
            ToTable("INADVICENURSE", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Advicetime).HasColumnName(@"ADVICETIME").IsRequired().HasColumnType("datetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.Hospid).HasColumnName(@"HOSPID").IsRequired().HasColumnType("int");
            Property(x => x.Groupnum).HasColumnName(@"GROUPNUM").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemID").IsRequired().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"DOSAGE").IsRequired().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.Unittakeid).HasColumnName(@"UNITTAKEID").IsOptional().HasColumnType("int");
            Property(x => x.Frequencyid).HasColumnName(@"FREQUENCYID").IsOptional().HasColumnType("int");
            Property(x => x.Usageid).HasColumnName(@"USAGEID").IsOptional().HasColumnType("int");
            Property(x => x.Pricein).HasColumnName(@"PRICEIN").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Totality).HasColumnName(@"TOTALITY").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Unitinid).HasColumnName(@"UNITINID").IsRequired().HasColumnType("int");
            Property(x => x.Isurgent).HasColumnName(@"ISURGENT").IsRequired().HasColumnType("bit");
            Property(x => x.Lsexecloc).HasColumnName(@"LSEXECLOC").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Isauth).HasColumnName(@"ISAUTH").IsRequired().HasColumnType("bit");
            Property(x => x.Authopertime).HasColumnName(@"AUTHOPERTIME").IsOptional().HasColumnType("datetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.Islong).HasColumnName(@"ISLONG").IsRequired().HasColumnType("bit");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.Cancelopertime).HasColumnName(@"CANCELOPERTIME").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.YbType).HasColumnName(@"YbType").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
        }
    }
}
