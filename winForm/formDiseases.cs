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
    public partial class formDiseases : Form
    {
        ClinicContext context;
        public formDiseases()
        {
            InitializeComponent();
        }

        private void formDiseases_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Додаємо колекцію сутностей до контексту
            context.Diseases.Load();

            // Прив’язуємо набір сутностей до елемента DataGridView
            gvDiseases.DataSource = context.Diseases.Local.ToBindingList();

            //Вилучаємо властивості навігації з інтерфейсу
            gvDiseases.Columns.Remove("PatientDiseases");
            gvDiseases.Columns.Remove("Histories");

            gvDiseases.Columns[0].HeaderText = "Код хвороби";
            gvDiseases.Columns[1].HeaderText = "Назва";

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gvDiseases.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
