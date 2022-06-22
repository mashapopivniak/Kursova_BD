
namespace winForm
{
    partial class formDoctorPatients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClinicDataSet = new winForm.ClinicDataSet();
            this.vDoctorPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDoctorPatientsTableAdapter = new winForm.ClinicDataSetTableAdapters.vDoctorPatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoctorPatientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(103, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Від:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "До:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(384, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 2;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.vDoctorPatientsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "winForm.rptDoctorPatients.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(72, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(506, 324);
            this.reportViewer1.TabIndex = 4;
            // 
            // ClinicDataSet
            // 
            this.ClinicDataSet.DataSetName = "ClinicDataSet";
            this.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDoctorPatientsBindingSource
            // 
            this.vDoctorPatientsBindingSource.DataMember = "vDoctorPatients";
            this.vDoctorPatientsBindingSource.DataSource = this.ClinicDataSet;
            // 
            // vDoctorPatientsTableAdapter
            // 
            this.vDoctorPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // formDoctorPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 422);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "formDoctorPatients";
            this.Text = "Пацієнти лікарів";
            this.Load += new System.EventHandler(this.formDoctorPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoctorPatientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vDoctorPatientsBindingSource;
        private ClinicDataSet ClinicDataSet;
        private ClinicDataSetTableAdapters.vDoctorPatientsTableAdapter vDoctorPatientsTableAdapter;
    }
}