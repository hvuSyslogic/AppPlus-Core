using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TmpOuEmrMap : EntityTypeConfiguration<TmpOuEmr>
    {
        public TmpOuEmrMap()
            : this("dbo")
        {
        }

        public TmpOuEmrMap(string schema)
        {
            ToTable("TmpOuEmr", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupMain).HasColumnName(@"GroupMain").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupSub).HasColumnName(@"GroupSub").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.LsOpenType).HasColumnName(@"LsOpenType").IsOptional().HasColumnType("smallint");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.MainInform).HasColumnName(@"MainInform").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.SickHist).HasColumnName(@"SickHist").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.ExamT).HasColumnName(@"ExamT").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamP).HasColumnName(@"ExamP").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamR).HasColumnName(@"ExamR").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamBp).HasColumnName(@"ExamBp").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamBp2).HasColumnName(@"ExamBp2").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.CheckUp).HasColumnName(@"CheckUp").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.CheckCt).HasColumnName(@"CheckCT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Disposal).HasColumnName(@"Disposal").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Impression).HasColumnName(@"Impression").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Analys).HasColumnName(@"Analys").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Others).HasColumnName(@"Others").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Tongue).HasColumnName(@"Tongue").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Pulse).HasColumnName(@"Pulse").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Moss).HasColumnName(@"Moss").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
