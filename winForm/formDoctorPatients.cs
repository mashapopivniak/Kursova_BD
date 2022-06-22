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
    public partial class formDoctorPatients : Form
    {
        public formDoctorPatients()
        {
            InitializeComponent();
        }

        private void formDoctorPatients_Load(object sender, EventArgs e)
        {
            // Створюємо типізований набір даних
            ClinicDataSet clinicDataSet = new ClinicDataSet();

            // Заповнюємо таблицю vDoctorPatients
            this.vDoctorPatientsTableAdapter.Fill(this.ClinicDataSet.vDoctorPatients);
            
            // Встановлюємо мін і макс дати
            DateTime Від = (from data in this.ClinicDataSet.vDoctorPatients.AsEnumerable()
                            select data.DiseaseBegin).Min();                
            dateTimePickerFrom.Value = Від;

            DateTime До = (from data in this.ClinicDataSet.vDoctorPatients.AsEnumerable()
                            select data.DiseaseEnd).Max();
            dateTimePickerTo.Value = До;

            // Дізнаємося значення вибраних дат
            DateTime beg = (DateTime)dateTimePickerFrom.Value;
            DateTime end = (DateTime)dateTimePickerTo.Value;
            
            string fltr = "[DiseaseBegin] >= '" + dateTimePickerFrom.Value +  "' And [DiseaseEnd] <= '" + dateTimePickerTo.Value + "'";
  
                // Відбираємо в DataSet потрібні дані 
               vDoctorPatientsBindingSource.Filter = fltr;
           

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            // Дізнаємося значення вибраних дат
            DateTime beg = (DateTime)dateTimePickerFrom.Value;
            DateTime end = (DateTime)dateTimePickerTo.Value;

            string fltr = "[DiseaseBegin] >= '" + dateTimePickerFrom.Value + "' And [DiseaseEnd] <= '" + dateTimePickerTo.Value + "'";

            // Відбираємо в DataSet потрібні дані 
            vDoctorPatientsBindingSource.Filter = fltr;


            this.reportViewer1.RefreshReport();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom_ValueChanged( sender,  e);
        }
    }
}
