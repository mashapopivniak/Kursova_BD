using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm
{
    public partial class formClinic : Form
    {
        public formClinic()
        {
            InitializeComponent();
        }

        private void buttonDiseases_Click(object sender, EventArgs e)
        {
            formDiseases вікноDiseases = new formDiseases();
            вікноDiseases.ShowDialog();

        }

        private void buttonSpecializations_Click(object sender, EventArgs e)
        {
            formSpecializations вікноSpecializations = new formSpecializations();
            вікноSpecializations.ShowDialog();
        }

        private void buttonDoctors_Click(object sender, EventArgs e)
        {
            formDoctors вікноDoctors = new formDoctors();
            вікноDoctors.ShowDialog();
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            formPatients вікноPatients = new formPatients();
            вікноPatients.ShowDialog();
        }

        private void buttonMedications_Click(object sender, EventArgs e)
        {
            //formMedications вікноMedications = new formMedications();
            //вікноMedications.ShowDialog();
        }

        private void buttonMedications_Click_1(object sender, EventArgs e)
        {
            formMeds вікноMedications = new formMeds();
            вікноMedications.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           formMeds вікноMedications = new formMeds();
            вікноMedications.ShowDialog();
        }

        private void Contraindications_Click(object sender, EventArgs e)
        {
            formContraindications вікноContraindications = new formContraindications();
            вікноContraindications.ShowDialog();

        }

        private void buttonHistories_Click(object sender, EventArgs e)
        {
            formHistories вікноHistories = new formHistories();
            вікноHistories.ShowDialog();
        }

        private void buttonPatientDiseases_Click(object sender, EventArgs e)
        {
            formPatientDiseases вікноPatientDiseases = new formPatientDiseases();
            вікноPatientDiseases.ShowDialog();
        }

        private void buttonMedUses_Click(object sender, EventArgs e)
        {
            formMedUses вікноMedUses = new formMedUses();
            вікноMedUses.ShowDialog();
        }

        private void buttondoctorPatients_Click(object sender, EventArgs e)
        {
            formDoctorPatients вікноDoctorPatients = new formDoctorPatients();
            вікноDoctorPatients.ShowDialog();
        }

        private void buttonpatientHistories_Click(object sender, EventArgs e)
        {
            formPatientHistories вікноPatientHistories = new formPatientHistories();
            вікноPatientHistories.ShowDialog();
        }

        private void buttonDoctorWorkloads_Click(object sender, EventArgs e)
        {
            formvDoctorWorkloads вікноDoctorWorkloads = new formvDoctorWorkloads();
            вікноDoctorWorkloads.ShowDialog();
        }
    }
}
