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
    public partial class formContraindications : Form
    {
        ClinicContext context;
        public formContraindications()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formContraindications_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Додаємо колекцію сутностей до контексту
            context.Contraindications.Load();

            // Завантажуємо дані для comboBoxs
            patientBindingSource.DataSource = context.Patients.ToList();
            medicationBindingSource.DataSource = context.Medications.ToList();

            // Прив’язуємо набір сутностей до елемента DataGridView
            contraindicationBindingSource.DataSource = context.Contraindications.Local.ToBindingList();
            //contraindicationDataGridView.DataSource = context.Contraindications.Local.ToBindingList();
        }

        private void contraindicationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            contraindicationBindingSource .EndEdit();
            context.SaveChanges();
            contraindicationDataGridView.Refresh();
        }

        private void contraindicationDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //Значення за замовчанням для стовпця Medication
             e.Row.Cells["dataGridViewComboBoxMedicationID"].Value = context.Medications.Min(t => t.MedicationID);

            //Значення за замовчанням для стовпця Patient
            e.Row.Cells["dataGridViewComboBoxPatientID"].Value = context.Patients.Min(t => t.PatientID);            
        }
    }
}
