
namespace winForm
{
    partial class formPatientHistories
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
            this.vPatientHistoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPatientHistoriesTableAdapter = new winForm.ClinicDataSetTableAdapters.vPatientHistoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPatientHistoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vPatientHistoriesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "winForm.rptPatientHistories.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(621, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClinicDataSet
            // 
            this.ClinicDataSet.DataSetName = "ClinicDataSet";
            this.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPatientHistoriesBindingSource
            // 
            this.vPatientHistoriesBindingSource.DataMember = "vPatientHistories";
            this.vPatientHistoriesBindingSource.DataSource = this.ClinicDataSet;
            // 
            // vPatientHistoriesTableAdapter
            // 
            this.vPatientHistoriesTableAdapter.ClearBeforeFill = true;
            // 
            // formPatientHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 403);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formPatientHistories";
            this.Text = "Історії хвороб";
            this.Load += new System.EventHandler(this.formPatientHistories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPatientHistoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vPatientHistoriesBindingSource;
        private ClinicDataSet ClinicDataSet;
        private ClinicDataSetTableAdapters.vPatientHistoriesTableAdapter vPatientHistoriesTableAdapter;
    }
}