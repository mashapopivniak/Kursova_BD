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
    public partial class formDoctors : Form
    {
        ClinicContext context;
        public formDoctors()
        {
            InitializeComponent();
        }

        private void formDoctors_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Завантажуємо дані для comboBoxs
            specializationBindingSource.DataSource = context.Specializations.ToList();

            // Завантажуємо дані для doctorBindingSource
            context.Doctors.Load();
            doctorBindingSource.DataSource = context.Doctors.Local.ToBindingList();
            
            // Кількість пацієнтів
            int doctorID= Int32.Parse(doctorDataGridView.Rows[0].Cells[0].Value.ToString());

            int countPatients = 
                (from p in context.PatientDiseases where (p.DoctorID == doctorID) && (!p.Cured) select p).Count();
            
            countPatientsTextBox.Text = countPatients.ToString();

            if (countPatients>=10)
            {
                countPatientsTextBox.ForeColor= Color.Red;
                labelMax.Visible = true;
            }
            else
            {
                countPatientsTextBox.ForeColor = Color.Black;
                labelMax.Visible = false;
            }
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            doctorDataGridView.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doctorDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.CanFocus) //Після завантаження
            {
                //Кількість пацієнтів

                int currentRow = doctorDataGridView.CurrentCell.RowIndex;

                int doctorID = Int32.Parse(doctorDataGridView.Rows[currentRow].Cells[0].Value.ToString());
                int countPatients =
                (from p in context.PatientDiseases where (p.DoctorID == doctorID) && (!p.Cured) select p).Count();
                countPatientsTextBox.Text = countPatients.ToString();

                if (countPatients >= 10)
                {
                    countPatientsTextBox.ForeColor = Color.Red;
                    labelMax.Visible = true;
                }
                else
                {
                    countPatientsTextBox.ForeColor = Color.Black;
                    labelMax.Visible = false;
                }
            }
        }

        private void doctorDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //Значення за замовчанням для стовпця Specialization
            e.Row.Cells["dataGridViewComboSpecializationID"].Value = context.Specializations.Min(t => t.SpecializationID);

        }
    }
}
