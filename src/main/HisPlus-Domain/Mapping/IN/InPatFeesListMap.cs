using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InPatFeesListMap : EntityTypeConfiguration<InPatFeesList>
    {
        public InPatFeesListMap()
            : this("dbo")
        {
        }

        public InPatFeesListMap(string schema)
        {
            ToTable("InPatFeesList", schema);
            HasKey(x => new { x.Id, x.HospId, x.InTime, x.PatTypeId });

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.BedId).HasColumnName(@"BedID").IsOptional().HasColumnType("int");
            Property(x => x.InTime).HasColumnName(@"InTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OutTime).HasColumnName(@"OutTime").IsOptional().HasColumnType("datetime");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeID").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationID").IsOptional().HasColumnType("int");
            Property(x => x.LocIn).HasColumnName(@"LocIn").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorID").IsOptional().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Deposit).HasColumnName(@"Deposit").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.NotPay).HasColumnName(@"NotPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.HasPay).HasColumnName(@"HasPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Remain).HasColumnName(@"Remain").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.AmountNoPay).HasColumnName(@"AmountNoPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPayNoPay).HasColumnName(@"AmountPayNoPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DepositNoPay).HasColumnName(@"DepositNoPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DepositMz).HasColumnName(@"DepositMz").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FactGet).HasColumnName(@"FactGet").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AllFactGet).HasColumnName(@"AllFactGet").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.YpAmount).HasColumnName(@"YPAmount").IsOptional().HasColumnType("decimal").HasPrecision(14,2);
            Property(x => x.Ypbl).HasColumnName(@"YPBL").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
        }
    }
}
