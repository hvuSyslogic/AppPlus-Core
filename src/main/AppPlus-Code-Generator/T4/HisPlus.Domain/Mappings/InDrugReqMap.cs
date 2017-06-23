using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDrugReqMap : EntityTypeConfiguration<InDrugReq>
    {
        public InDrugReqMap()
            : this("dbo")
        {
        }

        public InDrugReqMap(string schema)
        {
            ToTable("InDrugReq", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RequestNo).HasColumnName(@"RequestNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.LsSendStatus).HasColumnName(@"LsSendStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.ConfirmOperId).HasColumnName(@"ConfirmOperID").IsOptional().HasColumnType("int");
            Property(x => x.ConfirmDate).HasColumnName(@"ConfirmDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
