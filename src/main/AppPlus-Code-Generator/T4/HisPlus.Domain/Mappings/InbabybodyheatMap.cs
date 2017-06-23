using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InbabybodyheatMap : EntityTypeConfiguration<Inbabybodyheat>
    {
        public InbabybodyheatMap()
            : this("dbo")
        {
        }

        public InbabybodyheatMap(string schema)
        {
            ToTable("INBABYBODYHEAT", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Hospid).HasColumnName(@"hospid").IsRequired().HasColumnType("int");
            Property(x => x.Opertime).HasColumnName(@"opertime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Operid).HasColumnName(@"operid").IsRequired().HasColumnType("int");
            Property(x => x.Animalheat).HasColumnName(@"animalheat").IsRequired().HasColumnType("decimal").HasPrecision(3,1);
            Property(x => x.Heattype).HasColumnName(@"heattype").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Pulse).HasColumnName(@"pulse").IsRequired().HasColumnType("smallint");
            Property(x => x.Heart).HasColumnName(@"heart").IsRequired().HasColumnType("smallint");
            Property(x => x.Breath).HasColumnName(@"breath").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Stool).HasColumnName(@"stool").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Urine).HasColumnName(@"urine").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Weight).HasColumnName(@"weight").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Bldpress0).HasColumnName(@"bldpress0").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Bldpress1).HasColumnName(@"bldpress1").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Fluidm).HasColumnName(@"fluidm").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totalin).HasColumnName(@"totalin").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Urinem).HasColumnName(@"urinem").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Otherm).HasColumnName(@"otherm").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totalout).HasColumnName(@"totalout").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memoup).HasColumnName(@"memoup").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memodn).HasColumnName(@"memodn").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Spintest).HasColumnName(@"spintest").IsRequired().HasColumnType("bit");
            Property(x => x.Lowertemp).HasColumnName(@"lowertemp").IsRequired().HasColumnType("bit");
            Property(x => x.Isrecheck).HasColumnName(@"isrecheck").IsRequired().HasColumnType("bit");
            Property(x => x.Isoutside).HasColumnName(@"isoutside").IsRequired().HasColumnType("bit");
            Property(x => x.Ismachine).HasColumnName(@"ismachine").IsRequired().HasColumnType("bit");
            Property(x => x.Others).HasColumnName(@"others").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Isops).HasColumnName(@"isops").IsRequired().HasColumnType("bit");
            Property(x => x.Birthtime).HasColumnName(@"birthtime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Isreject).HasColumnName(@"isreject").IsRequired().HasColumnType("bit");
            Property(x => x.Deadtime).HasColumnName(@"deadtime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Locationid).HasColumnName(@"locationid").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"f1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"f2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"f3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"f4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Bg).HasColumnName(@"bg").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Cwinject).HasColumnName(@"cwinject").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Jminject).HasColumnName(@"jminject").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Cwheight).HasColumnName(@"cwheight").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Ismotherfeed).HasColumnName(@"ismotherfeed").IsOptional().HasColumnType("bit");
            Property(x => x.Ishumanfeed).HasColumnName(@"ishumanfeed").IsOptional().HasColumnType("bit");
            Property(x => x.Ubsstool).HasColumnName(@"ubsstool").IsOptional().HasColumnType("int");
            Property(x => x.Umbilical).HasColumnName(@"umbilical").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"f5").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F6).HasColumnName(@"f6").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
