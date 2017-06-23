using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdHurtMap : EntityTypeConfiguration<RdHurt>
    {
        public RdHurtMap()
            : this("dbo")
        {
        }

        public RdHurtMap(string schema)
        {
            ToTable("RdHurt", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.HospitalCode).HasColumnName(@"HospitalCode").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.HurtTime).HasColumnName(@"HurtTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DiagDate).HasColumnName(@"DiagDate").IsOptional().HasColumnType("datetime");
            Property(x => x.LsHurtReason).HasColumnName(@"LsHurtReason").IsOptional().HasColumnType("int");
            Property(x => x.LsHurtCensus).HasColumnName(@"LsHurtCensus").IsOptional().HasColumnType("int");
            Property(x => x.ElHurtReason).HasColumnName(@"ElHurtReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHurtPlace).HasColumnName(@"LsHurtPlace").IsOptional().HasColumnType("int");
            Property(x => x.ElHurtPlace).HasColumnName(@"ElHurtPlace").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHurtActivity).HasColumnName(@"LsHurtActivity").IsOptional().HasColumnType("int");
            Property(x => x.ElHurtActivity).HasColumnName(@"ElHurtActivity").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsIsDeliberately).HasColumnName(@"LsIsDeliberately").IsOptional().HasColumnType("int");
            Property(x => x.LsHurtNature).HasColumnName(@"LsHurtNature").IsOptional().HasColumnType("int");
            Property(x => x.ElHurtNature).HasColumnName(@"ElHurtNature").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHurtPosition).HasColumnName(@"LsHurtPosition").IsOptional().HasColumnType("int");
            Property(x => x.ElHurtPosition).HasColumnName(@"ElHurtPosition").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHurtDegree).HasColumnName(@"LsHurtDegree").IsOptional().HasColumnType("int");
            Property(x => x.HurtClinical).HasColumnName(@"HurtClinical").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHurtEnding).HasColumnName(@"LsHurtEnding").IsOptional().HasColumnType("int");
            Property(x => x.ElHurtEnding).HasColumnName(@"ElHurtEnding").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHurtProduct).HasColumnName(@"LsHurtProduct").IsOptional().HasColumnType("int");
            Property(x => x.LsHurtProducts).HasColumnName(@"LsHurtProducts").IsOptional().HasColumnType("int");
            Property(x => x.ProductName).HasColumnName(@"ProductName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProductNames).HasColumnName(@"ProductNames").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProductType).HasColumnName(@"ProductType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProductTypes).HasColumnName(@"ProductTypes").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Typical).HasColumnName(@"Typical").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
