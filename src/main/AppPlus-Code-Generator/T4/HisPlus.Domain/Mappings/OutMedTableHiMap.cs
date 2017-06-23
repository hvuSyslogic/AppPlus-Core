using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OutMedTableHiMap : EntityTypeConfiguration<OutMedTableHi>
    {
        public OutMedTableHiMap()
            : this("dbo")
        {
        }

        public OutMedTableHiMap(string schema)
        {
            ToTable("OutMedTableHis", schema);
            HasKey(x => x.Id);

            Property(x => x.PresNo).HasColumnName(@"PresNO").IsRequired().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.MedId).HasColumnName(@"MedID").IsRequired().HasColumnType("int");
            Property(x => x.MedOnlyCode).HasColumnName(@"MedOnlyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.MedAmt).HasColumnName(@"MedAMT").IsRequired().HasColumnType("int");
            Property(x => x.MedPack).HasColumnName(@"MedPack").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.MedUnitPack).HasColumnName(@"MedUnitPack").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.MedUnit).HasColumnName(@"MedUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.MedOutTime).HasColumnName(@"MedOutTime").IsRequired().HasColumnType("date");
            Property(x => x.PresType).HasColumnName(@"PresType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.WindowNo).HasColumnName(@"WindowNO").IsRequired().HasColumnType("int");
            Property(x => x.PatientId).HasColumnName(@"PatientID").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.PatientName).HasColumnName(@"PatientName").IsRequired().HasColumnType("nvarchar").HasMaxLength(64);
            Property(x => x.PatientSex).HasColumnName(@"PatientSex").IsRequired().HasColumnType("nvarchar").HasMaxLength(8);
            Property(x => x.PatientAge).HasColumnName(@"PatientAge").IsOptional().HasColumnType("nvarchar").HasMaxLength(8);
            Property(x => x.PatientBirth).HasColumnName(@"PatientBirth").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Diagnosis).HasColumnName(@"Diagnosis").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.WardNo).HasColumnName(@"WardNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.WardName).HasColumnName(@"WardName").IsOptional().HasColumnType("nvarchar").HasMaxLength(64);
            Property(x => x.MedPerdos).HasColumnName(@"MedPerdos").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.MedUsage).HasColumnName(@"MedUsage").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
            Property(x => x.MedPerday).HasColumnName(@"MedPerday").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.DoctorName).HasColumnName(@"DoctorName").IsOptional().HasColumnType("nvarchar").HasMaxLength(64);
            Property(x => x.Fpno).HasColumnName(@"FPNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.SEndflag).HasColumnName(@"SEndflag").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.MedUnitPrice).HasColumnName(@"MedUnitPrice").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.MedTotalPrice).HasColumnName(@"MedTotalPrice").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MedType).HasColumnName(@"MedType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.MedConvercof).HasColumnName(@"MedConvercof").IsOptional().HasColumnType("int");
            Property(x => x.Remark).HasColumnName(@"Remark").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.YfCode).HasColumnName(@"YFCode").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Endflag).HasColumnName(@"Endflag").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YfFinish).HasColumnName(@"YfFinish").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
        }
    }
}
