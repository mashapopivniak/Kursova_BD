using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using modeling.Models;
using modeling.DataAccess;


namespace modeling.Fill
{
    public class DataAdd
    {
     public static void FillDB(out int nDisease,
     out int nSpecialization,
     out int nDoctor,
     out int nPatient,
     out int nHistory,
     out int nPatientDisease,
     out int nMedication,
     out int nMedicationPart,
     out int nMedUse,
     out int nContraindication)
        {
            var diseases = new List<Disease>
    {
        new Disease { DiseaseName = @"Застуда"},
        new Disease { DiseaseName = @"ОРЗ"},
        new Disease { DiseaseName = @"Гіпертонія"},
        new Disease { DiseaseName = @"Перелом"},
        new Disease { DiseaseName = @"Апендицит"}
    };
            using (var context = new ClinicContext())
            {
                diseases.ForEach(d => context.Diseases.Add(d));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nDisease = context.Diseases.Count();
            }

            var specializations = new List<Specialization>
    {
        new Specialization { SpecializationName = @"Терапевт"},
        new Specialization { SpecializationName = @"Хірург"}
    };
            using (var context = new ClinicContext())
            {
                specializations.ForEach(s => context.Specializations.Add(s));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nSpecialization = context.Specializations.Count();
            }

            var doctors = new List<Doctor>
    {
        new Doctor { DoctorName = @"Іваненко",Address=@"вул. Незалежності, 10, кв.1", SpecializationID=1},
        new Doctor { DoctorName = @"Петренко",Address=@"вул. Свободи, 4, кв.11", SpecializationID=1},
        new Doctor { DoctorName = @"Сидоренко",Address=@"вул. Перемоги, 12, кв.12", SpecializationID=2}
    };
            using (var context = new ClinicContext())
            {
                doctors.ForEach(d => context.Doctors.Add(d));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nDoctor = context.Doctors.Count();
            }

            var patients = new List<Patient>
    {
        new Patient { LastName = @"Іванчук", FirstName=@"Іван", SurName= @"Іванович", Address=@"вул. Незалежності, 5, кв.15", Comment=@"Послаблений імунітет"},
        new Patient { LastName = @"Іванченко", FirstName=@"Микола", SurName= @"Іванович", Address=@"вул. Свободи, 14, кв.11"},
        new Patient { LastName = @"Іванчан", FirstName=@"Іван", SurName= @"Васильович", Address=@"вул. Свободи, 24, кв.14"},
        new Patient { LastName = @"Петренко ", FirstName=@"Петро", SurName= @"Петрович", Address=@"вул. Свободи, 20, кв.1"},
        new Patient { LastName = @"Петриченко", FirstName=@"Іван", SurName= @"Васильович", Address=@"вул. Незалежності, 11, кв.1"},
        
        new Patient { LastName = @"Петренчук", FirstName=@"Микола", SurName= @"Петрович", Address=@"вул. Незалежності, 21, кв.1"},
        new Patient { LastName = @"Петренко", FirstName=@"Семен", SurName= @"Петрович", Address=@"вул. Незалежності, 21, кв.1"},
        new Patient { LastName = @"Петриченко", FirstName=@"Микола", SurName= @"Васильович", Address=@"вул. Незалежності, 11, кв.1"},

        new Patient { LastName = @"Сидоренко", FirstName=@"Сидір", SurName= @"Сидорович", Address=@"вул. Перемоги, 12, кв.12"},
        new Patient { LastName = @"Сидоренко ", FirstName=@"Петро", SurName= @"Петрович", Address=@"вул. Перемоги, 22, кв.12"},
        new Patient { LastName = @"Сидоренко", FirstName=@"Семен", SurName= @"Сидорович", Address=@"вул. Перемоги, 22, кв.12"},
        new Patient { LastName = @"Сидоренко", FirstName=@"Сидір", SurName= @"Петрович", Address=@"вул. Свободи, 22, кв.12"}
     };
            using (var context = new ClinicContext())
            {
                patients.ForEach(p => context.Patients.Add(p));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nPatient = context.Patients.Count();
            }


            var histories = new List<History>
    {
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=1, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=2, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=3, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=4, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=5, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=6, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=7, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=8, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=1, DoctorID=3, DiseaseID=3},
        new History { AppDate = DateTime.Parse("05.05.2022"), PatientID=9, DoctorID=1, DiseaseID=2},
        new History { AppDate = DateTime.Parse("06.05.2022"), PatientID=9, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("06.05.2022"), PatientID=10, DoctorID=1, DiseaseID=1},
        new History { AppDate = DateTime.Parse("06.05.2022"), PatientID=1, DoctorID=3, DiseaseID=3},
        new History { AppDate = DateTime.Parse("06.05.2022"), PatientID=9, DoctorID=1, DiseaseID=2}
    };
            using (var context = new ClinicContext())
            {
                histories.ForEach(d => context.Histories.Add(d));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nHistory = context.Histories.Count();
            }


            var patientDiseases = new List<PatientDisease>
    {
        new PatientDisease { PatientID = 1, DoctorID=1, DiseaseID=1, DiseaseBegin= DateTime.Parse("06.04.2022"), DiseaseEnd= DateTime.Parse("06.05.2022"), Rating=95, Cured=true},
        new PatientDisease { PatientID = 2, DoctorID=1, DiseaseID=1, DiseaseBegin= DateTime.Parse("06.01.2022"), DiseaseEnd= DateTime.Parse("06.05.2022"), Rating=5, Cured=false, Accounting=true},
        new PatientDisease { PatientID = 6, DoctorID=3, DiseaseID=4, DiseaseBegin= DateTime.Parse("06.04.2022"), DiseaseEnd= DateTime.Parse("06.05.2022"), Rating=95, Cured=true}
    };
            using (var context = new ClinicContext())
            {
                patientDiseases.ForEach(d => context.PatientDiseases.Add(d));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nPatientDisease = context.PatientDiseases.Count();
            }

            var medications = new List<Medication>
    {
        new Medication { MedicationName = @"Панадол"},
        new Medication { MedicationName = @"Аспірин"},
        new Medication { MedicationName = @"Парацитамол"},
        new Medication { MedicationName = @"Цитрамон"},
    };
            using (var context = new ClinicContext())
            {
                medications.ForEach(m => context.Medications.Add(m));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nMedication = context.Medications.Count();
            }

            var medicationParts = new List<MedicationPart>
    {
        new MedicationPart { MedicationID = 4, IncludeID=2},
        new MedicationPart { MedicationID = 4, IncludeID=3}
    };
            using (var context = new ClinicContext())
            {
                medicationParts.ForEach(m => context.MedicationParts.Add(m));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nMedicationPart = context.MedicationParts.Count();
            }

            var medUses = new List<MedUse>
    {
        new MedUse {HistoryID=1, MedicationID = 1},
        new MedUse {HistoryID=2, MedicationID = 1},
        new MedUse {HistoryID=3, MedicationID = 2},
        new MedUse {HistoryID=3, MedicationID = 1}
    };
            using (var context = new ClinicContext())
            {
                medUses.ForEach(m => context.MedUses.Add(m));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nMedUse = context.MedUses.Count();
            }

            var contraindications = new List<Contraindication>
    {
        new Contraindication {PatientID=1, MedicationID = 3},
        new Contraindication {PatientID=1, MedicationID = 4}
    };
            using (var context = new ClinicContext())
            {
                contraindications.ForEach(c => context.Contraindications.Add(c));
                context.SaveChanges();
                // Визначаємо кількість доданих рядків
                nContraindication = context.Contraindications.Count();
            }
          
        }

    }
}
