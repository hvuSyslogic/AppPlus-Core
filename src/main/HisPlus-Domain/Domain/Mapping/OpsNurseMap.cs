using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OpsNurseMap : EntityTypeConfiguration<OpsNurse>
    {
        public OpsNurseMap()
            : this("dbo")
        {
        }

        public OpsNurseMap(string schema)
        {
            ToTable("OpsNurse", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsRequired().HasColumnType("int");
            Property(x => x.HandWashingNurse).HasColumnName(@"Hand Washing  Nurse").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReplaceHandNurse).HasColumnName(@"Replace Hand  Nurse").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TakeTime).HasColumnName(@"Take Time").IsRequired().HasColumnType("datetime");
            Property(x => x.VisitingNurse).HasColumnName(@"Visiting Nurse").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReplaceVisitingNurse).HasColumnName(@"Replace Visiting Nurse").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TakeTime2).HasColumnName(@"Take Time2").IsRequired().HasColumnType("datetime");
            Property(x => x.SurgeryPosition).HasColumnName(@"Surgery Position").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
            Property(x => x.LocalAnesthesiaIsDrugUse).HasColumnName(@"Local Anesthesia Is Drug Use").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Constrained).HasColumnName(@"Constrained").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AHand).HasColumnName(@"A Hand").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
            Property(x => x.AirTime).HasColumnName(@"Air Time").IsRequired().HasColumnType("datetime");
            Property(x => x.PhoebeTime).HasColumnName(@"Phoebe Time").IsRequired().HasColumnType("datetime");
            Property(x => x.NegativePlate).HasColumnName(@"Negative Plate").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
            Property(x => x.AirTime2).HasColumnName(@"Air Time2").IsRequired().HasColumnType("datetime");
            Property(x => x.PhoebeTime2).HasColumnName(@"Phoebe Time2").IsRequired().HasColumnType("datetime");
            Property(x => x.InfusionParts).HasColumnName(@"Infusion Parts").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
            Property(x => x.AirTime3).HasColumnName(@"Air time3").IsRequired().HasColumnType("datetime");
            Property(x => x.PhoebeTime3).HasColumnName(@"Phoebe Time3").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
            Property(x => x.PicassoSkinCond).HasColumnName(@"Picasso  Skin Cond").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CatheterizationOperatingRoom).HasColumnName(@"Catheterization Operating Room").IsRequired().HasColumnType("bit");
            Property(x => x.TheCatheter).HasColumnName(@"The catheter").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Electrotome).HasColumnName(@"Electrotome").IsRequired().HasColumnType("bit");
            Property(x => x.ArgonKnife).HasColumnName(@"Argon Knife").IsRequired().HasColumnType("bit");
            Property(x => x.BipolarOfElectricity).HasColumnName(@"Bipolar Of Electricity").IsRequired().HasColumnType("bit");
            Property(x => x.UltrasoundScalpel).HasColumnName(@"Ultrasound Scalpel").IsRequired().HasColumnType("bit");
            Property(x => x.IsSendFrozenSection).HasColumnName(@"IsSend Frozen Section").IsRequired().HasColumnType("bit");
            Property(x => x.IsForPathologicSpecimens).HasColumnName(@"IsFor Pathologic Specimens").IsRequired().HasColumnType("bit");
            Property(x => x.IsSendBacteriaCultivation).HasColumnName(@"IsSend Bacteria Cultivation").IsRequired().HasColumnType("bit");
            Property(x => x.IsAsepticPackagePassedExamination).HasColumnName(@"IsAseptic Package Passed  Examination").IsRequired().HasColumnType("bit");
            Property(x => x.IsSurgicalItemsInventory).HasColumnName(@"IsSurgical Items Inventory").IsRequired().HasColumnType("bit");
            Property(x => x.TotalIntake).HasColumnName(@"Total Intake").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AlwaysGgivesQuantity).HasColumnName(@"Always Ggives Quantity").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Implant).HasColumnName(@"Implant").IsRequired().HasColumnType("bit");
            Property(x => x.Parts).HasColumnName(@"Parts").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
