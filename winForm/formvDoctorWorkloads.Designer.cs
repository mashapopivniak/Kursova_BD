﻿
namespace winForm
{
    partial class formvDoctorWorkloads
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClinicDataSet = new winForm.ClinicDataSet();
            this.vDoctorWorkloadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDoctorWorkloadsTableAdapter = new winForm.ClinicDataSetTableAdapters.vDoctorWorkloadsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoctorWorkloadsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vDoctorWorkloadsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "winForm.rptDoctorWorkloads.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(465, 304);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClinicDataSet
            // 
            this.ClinicDataSet.DataSetName = "ClinicDataSet";
            this.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDoctorWorkloadsBindingSource
            // 
            this.vDoctorWorkloadsBindingSource.DataMember = "vDoctorWorkloads";
            this.vDoctorWorkloadsBindingSource.DataSource = this.ClinicDataSet;
            // 
            // vDoctorWorkloadsTableAdapter
            // 
            this.vDoctorWorkloadsTableAdapter.ClearBeforeFill = true;
            // 
            // formvDoctorWorkloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 364);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formvDoctorWorkloads";
            this.Text = "Завантаженість лікарів";
            this.Load += new System.EventHandler(this.formvDoctorWorkloads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDoctorWorkloadsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vDoctorWorkloadsBindingSource;
        private ClinicDataSet ClinicDataSet;
        private ClinicDataSetTableAdapters.vDoctorWorkloadsTableAdapter vDoctorWorkloadsTableAdapter;
    }
}