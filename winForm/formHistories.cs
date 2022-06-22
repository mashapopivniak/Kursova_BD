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
    public partial class formHistories : Form
    {
        ClinicContext context;
        public formHistories()
        {
            InitializeComponent();
        }

        private void formHistories_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Завантажуємо дані для comboBoxs
            //patientBindingSource.DataSource = context.Patients.ToList();

            // Завантажуємо дані для doctorBindingSource         
            doctorBindingSource.DataSource = context.Doctors.ToList();

            // Завантажуємо дані для diseaseBindingSource         
            diseaseBindingSource.DataSource = context.Diseases.ToList();

            // Завантажуємо дані для patientBindingSource
            context.Patients.Load();
            patientBindingSource.DataSource = context.Patients.Local.ToBindingList();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            historiesBindingSource.EndEdit();
            patientBindingSource.EndEdit();
            context.SaveChanges();

            // Оновлення даних на формі
            historiesBindingSource.MovePrevious();
            historiesBindingSource.MoveNext();
        }

        private void historiesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void historiesDataGridView_DefaultValuesNeeded_1(object sender, DataGridViewRowEventArgs e)
        {            
            //Значення за замовчанням для стовпця Doctor
            e.Row.Cells["dataGridViewComboBoxDoctorID"].Value = context.Doctors.Min(t => t.DoctorID);

            //Значення за замовчанням для стовпця Disease
            e.Row.Cells["dataGridViewComboBoxDiseaseID"].Value = context.Diseases.Min(t => t.DiseaseID);

        }
    }
}
