using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OpsPostTreatMap : EntityTypeConfiguration<OpsPostTreat>
    {
        public OpsPostTreatMap()
            : this("dbo")
        {
        }

        public OpsPostTreatMap(string schema)
        {
            ToTable("OpsPostTreat", schema);
            HasKey(x => new { x.DrawingTubeSites, x.TrachealIntubationTimeOut, x.ThePatientTo, x.Time, x.DoctorSignature, x.NurseSignature, x.InTheRecoveryRoomAnesthesiaPatientsState, x.ThePatientIsInTheRecoveryRoom, x.ThePatientRecoveryRoom, x.AnesthesiaRecoveryAfterScoring, x.TrachealIntubationTimeOut1, x.TheTimeTheRecoveryRoom, x.TransitThePatient39SConditionMonitoring, x.Patient, x.Entourage, x.IsHappening, x.ThePatientSentToTheWardBothSidesHandoverProject, x.TheRecoveryRoomSignTheNurseInCharge });

            Property(x => x.DrawingTubeSites).HasColumnName(@"Drawing tube sites").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TrachealIntubationTimeOut).HasColumnName(@"Tracheal intubation time out").IsRequired().HasColumnType("datetime");
            Property(x => x.ThePatientTo).HasColumnName(@"The patient to").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Time).HasColumnName(@"Time").IsRequired().HasColumnType("datetime");
            Property(x => x.DoctorSignature).HasColumnName(@"Doctor signature").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NurseSignature).HasColumnName(@"Nurse signature").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InTheRecoveryRoomAnesthesiaPatientsState).HasColumnName(@"In the recovery room anesthesia patients state").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ThePatientIsInTheRecoveryRoom).HasColumnName(@"The patient is in the recovery room").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ThePatientRecoveryRoom).HasColumnName(@"The patient recovery room").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.AnesthesiaRecoveryAfterScoring).HasColumnName(@"Anesthesia recovery after scoring").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.TrachealIntubationTimeOut1).HasColumnName(@"Tracheal intubation time out1").IsRequired().HasColumnType("datetime");
            Property(x => x.TheTimeTheRecoveryRoom).HasColumnName(@"The time the recovery room").IsRequired().HasColumnType("datetime");
            Property(x => x.TransitThePatient39SConditionMonitoring).HasColumnName(@"Transit the patient's condition monitoring").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Patient).HasColumnName(@"Patient").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Entourage).HasColumnName(@"Entourage").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsHappening).HasColumnName(@"Is happening").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ThePatientSentToTheWardBothSidesHandoverProject).HasColumnName(@"The patient sent to the ward both sides handover project").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.TheRecoveryRoomSignTheNurseInCharge).HasColumnName(@"The recovery room sign the nurse in charge").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
