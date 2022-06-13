using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using modeling.DataAccess;
using modeling.Fill;


namespace modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Стратегія роботи з базою даних
                Database.SetInitializer(
                    new DropCreateDatabaseAlways<ClinicContext>());

                // Описуємо фактичні параметри методу FillDB
                int nDisease;
                int nSpecialization;
                int nDoctor;
                int nPatient;
                int nHistory;
                int nPatientDisease;
                int nMedication;
                int nMedicationPart;
                int nMedUse;
                int nContraindication;

                // Викликаємо метод
                DataAdd.FillDB(out nDisease,
                     out nSpecialization,
                     out nDoctor,
                     out nPatient,
                     out nHistory,
                     out nPatientDisease,
                     out nMedication,
                     out nMedicationPart,
                     out nMedUse,
                     out nContraindication
                   );

                // Виводимо результат
                Console.WriteLine(
                    "Базу даних на SQL Server створено і заповнено.\n"
                    + "У таблиці записано таку кількість рядків:\n"
                    + "Diseases - " + nDisease /*
                    + ", Specializations - " + nSpecialization
                    + ",  Doctors - " + nDoctor
                    */
                    + ".\n Перевірте!!!");
            }
            catch (System.Exception ex)
            {
                // Виводимо повідомлення про помилку
                Console.WriteLine("Базу даних не створено. \n Помилка:\n "
                + ex.ToString());
            }

            // Виводимо повідомлення про подальші дії
            Console.WriteLine("Натисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();

        }
    }
}
