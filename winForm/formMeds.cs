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
    public partial class formMeds : Form
    {
        ClinicContext context;
        public formMeds()
        {
            InitializeComponent();
        }

        private void formMeds_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Завантажуємо дані для medicationBindingSource
            context.Medications.Load();

            medicationBindingSource.DataSource =
                context.Medications.Local.ToBindingList();
        }

        private void medicationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            medicationBindingSource.EndEdit();
            context.SaveChanges();

            // Оновлення даних на формі
            medicationBindingSource.MovePrevious();
            medicationBindingSource.MoveNext();
        }

        private void medicationPartsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //Значення за замовчанням для стовпця Товар

            /*
            e.Row.Cells["dataGridViewTextBoxColumn2"].Value = this.medicationIDTextBox.Text;
                context.Medications.Min(t => t.MedicationID);
            */

            e.Row.Cells["dataGridViewComboBoxIncludeID"].Value =
                context.Medications.Min(t => t.MedicationID);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
