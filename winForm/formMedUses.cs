using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using modeling.DataAccess;

namespace winForm
{
    public partial class formMedUses : Form
    {
        ClinicContext context;
        public formMedUses()
        {
            InitializeComponent();
        }

        private void formMedUses_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Завантажуємо дані для comboBoxs
            patientBindingSource.DataSource = context.Patients.ToList();

            // Завантажуємо дані для doctorBindingSource         
            doctorBindingSource.DataSource = context.Doctors.ToList();

            // Завантажуємо дані для diseaseBindingSource         
            diseaseBindingSource.DataSource = context.Diseases.ToList();


            // Завантажуємо дані для medicationBindingSource         
            medicationBindingSource.DataSource = context.Medications.ToList();

            // Завантажуємо дані для сontraindicationsBindingSource         
            сontraindicationsBindingSource.DataSource = context.Contraindications.ToList();

            // Завантажуємо дані для doctorBindingSource
            context.Histories.Load();
            historyBindingSource.DataSource = context.Histories.Local.ToBindingList();

            //*** Обмеження по ліках першого пацієнта ***********
            // Відбираємо дані про пацієнта
            var querySeachContraindications =
                from сontraindication in context.Contraindications
                where сontraindication.PatientID == 1
                select new
                {
                    Ліки = сontraindication.Medication.MedicationName
                };

            // Відображаємо дані
            сontraindicationsDataGridView.DataSource = querySeachContraindications.ToList();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            patientBindingSource.EndEdit();
            doctorBindingSource.EndEdit();
            diseaseBindingSource.EndEdit();
            historyBindingSource.EndEdit();

            context.SaveChanges();

            // Оновлення даних на формі
            patientBindingSource.MovePrevious();
            patientBindingSource.MoveNext();
        }

        private void medUsesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {            
             //Значення за замовчанням для стовпця Doctor
            e.Row.Cells["dataGridViewComboBoxMedicationID"].Value = context.Medications.Min(t => t.MedicationID);
        }

        private void historyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Знаходимо код пацієнта
            int patientID = (int)historyDataGridView.Rows[e.RowIndex].Cells[2].Value;
            
            // Відбираємо дані про пацієнта
            var querySeachContraindications = 
                from сontraindication in context.Contraindications
                where сontraindication.PatientID== patientID
                select new
                        {
                            Ліки = сontraindication.Medication.MedicationName
                        };

            // Відображаємо дані
            сontraindicationsDataGridView.DataSource = querySeachContraindications.ToList();
        }
    }
}
