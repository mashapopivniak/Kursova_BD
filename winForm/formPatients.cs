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
    public partial class formPatients : Form
    {
        ClinicContext context;
        public formPatients()
        {
            InitializeComponent();
        }

        private void formPatients_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Додаємо колекцію сутностей до контексту
            context.Patients.Load();

            // Прив’язуємо набір сутностей до елемента DataGridView
            gvPatients.DataSource = context.Patients.Local.ToBindingList();

            //Вилучаємо властивості навігації з інтерфейсу
            //gvPatients.Columns.Remove("Histories");
            //gvPatients.Columns.Remove("PatientDiseases");
            //gvPatients.Columns.Remove("Contraindication");

            gvPatients.Columns[0].HeaderText = "Код пацієнта";
            gvPatients.Columns[1].HeaderText = "Прізвище";
            gvPatients.Columns[2].HeaderText = "Ім'я";
            gvPatients.Columns[3].HeaderText = "По батькові";
            gvPatients.Columns[4].HeaderText = "Адреса";
            gvPatients.Columns[5].HeaderText = "Примітка";

            gvPatients.AutoResizeColumns();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gvPatients.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
