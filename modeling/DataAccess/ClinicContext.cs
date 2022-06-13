using System.Data.Entity;
using modeling.Models;


namespace modeling.DataAccess
{
    public class ClinicContext : DbContext
    {
        public DbSet<Contraindication> Contraindications { get; set; }
        public DbSet<Disease> Diseases { get; set; }        
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationPart> MedicationParts { get; set; }
        public DbSet<MedUse> MedUses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDisease> PatientDiseases { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
    }
}
