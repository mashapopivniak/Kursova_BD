﻿using System;
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
    public partial class formPatientHistories : Form
    {
        public formPatientHistories()
        {
            InitializeComponent();
        }

        private void formPatientHistories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClinicDataSet.vPatientHistories' table. You can move, or remove it, as needed.
            this.vPatientHistoriesTableAdapter.Fill(this.ClinicDataSet.vPatientHistories);

            this.reportViewer1.RefreshReport();
        }
    }
}
