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
    public partial class formSpecializations : Form
    {
        ClinicContext context;
        public formSpecializations()
        {
            InitializeComponent();
        }

        private void formSpecializations_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClinicContext();

            // Додаємо колекцію сутностей до контексту
            context.Specializations.Load();

            // Прив’язуємо набір сутностей до елемента DataGridView
            gvSpecializations.DataSource = context.Specializations.Local.ToBindingList();

            //Вилучаємо властивості навігації з інтерфейсу
            gvSpecializations.Columns.Remove("Doctors");

            gvSpecializations.Columns[0].HeaderText = "Код спеціалізації";
            gvSpecializations.Columns[1].HeaderText = "Спеціалізація";

            gvSpecializations.AutoResizeColumns();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gvSpecializations.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
