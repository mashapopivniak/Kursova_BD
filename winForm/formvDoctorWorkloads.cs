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
    public partial class formvDoctorWorkloads : Form
    {
        public formvDoctorWorkloads()
        {
            InitializeComponent();
        }

        private void formvDoctorWorkloads_Load(object sender, EventArgs e)
        {

            this.vDoctorWorkloadsTableAdapter.Fill(this.ClinicDataSet.vDoctorWorkloads);

            this.reportViewer1.RefreshReport();
        }
    }
}
