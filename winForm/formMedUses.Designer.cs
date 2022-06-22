
namespace winForm
{
    partial class formMedUses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMedUses));
            this.historyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.medUsesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.сontraindicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medUsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сontraindicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxMedicationID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingNavigator)).BeginInit();
            this.historyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medUsesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontraindicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medUsesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontraindicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historyBindingNavigator
            // 
            this.historyBindingNavigator.AddNewItem = null;
            this.historyBindingNavigator.BindingSource = this.historyBindingSource;
            this.historyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.historyBindingNavigatorSaveItem});
            this.historyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historyBindingNavigator.Name = "historyBindingNavigator";
            this.historyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historyBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.historyBindingNavigator.TabIndex = 0;
            this.historyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // historyBindingNavigatorSaveItem
            // 
            this.historyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historyBindingNavigatorSaveItem.Image")));
            this.historyBindingNavigatorSaveItem.Name = "historyBindingNavigatorSaveItem";
            this.historyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.historyBindingNavigatorSaveItem.Text = "Save Data";
            this.historyBindingNavigatorSaveItem.Click += new System.EventHandler(this.historyBindingNavigatorSaveItem_Click);
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Location = new System.Drawing.Point(20, 60);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(513, 220);
            this.historyDataGridView.TabIndex = 1;
            this.historyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyDataGridView_CellClick);
            // 
            // medUsesDataGridView
            // 
            this.medUsesDataGridView.AutoGenerateColumns = false;
            this.medUsesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medUsesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewComboBoxMedicationID});
            this.medUsesDataGridView.DataSource = this.medUsesBindingSource;
            this.medUsesDataGridView.Location = new System.Drawing.Point(82, 320);
            this.medUsesDataGridView.Name = "medUsesDataGridView";
            this.medUsesDataGridView.Size = new System.Drawing.Size(162, 208);
            this.medUsesDataGridView.TabIndex = 2;
            this.medUsesDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.medUsesDataGridView_DefaultValuesNeeded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Відвідування:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Призначення:";
            // 
            // сontraindicationsDataGridView
            // 
            this.сontraindicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сontraindicationsDataGridView.Location = new System.Drawing.Point(347, 320);
            this.сontraindicationsDataGridView.Name = "сontraindicationsDataGridView";
            this.сontraindicationsDataGridView.Size = new System.Drawing.Size(148, 208);
            this.сontraindicationsDataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Протипоказання:";
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataSource = typeof(modeling.Models.Medication);
            // 
            // medUsesBindingSource
            // 
            this.medUsesBindingSource.DataMember = "MedUses";
            this.medUsesBindingSource.DataSource = this.historyBindingSource;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(modeling.Models.History);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(modeling.Models.Patient);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(modeling.Models.Doctor);
            // 
            // diseaseBindingSource
            // 
            this.diseaseBindingSource.DataSource = typeof(modeling.Models.Disease);
            // 
            // сontraindicationsBindingSource
            // 
            this.сontraindicationsBindingSource.DataMember = "Сontraindications";
            this.сontraindicationsBindingSource.DataSource = this.patientBindingSource;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MedUseID";
            this.dataGridViewTextBoxColumn7.HeaderText = "MedUseID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HistoryID";
            this.dataGridViewTextBoxColumn8.HeaderText = "HistoryID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewComboBoxMedicationID
            // 
            this.dataGridViewComboBoxMedicationID.DataPropertyName = "MedicationID";
            this.dataGridViewComboBoxMedicationID.DataSource = this.medicationBindingSource;
            this.dataGridViewComboBoxMedicationID.DisplayMember = "MedicationName";
            this.dataGridViewComboBoxMedicationID.HeaderText = "Ліки";
            this.dataGridViewComboBoxMedicationID.Name = "dataGridViewComboBoxMedicationID";
            this.dataGridViewComboBoxMedicationID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxMedicationID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxMedicationID.ValueMember = "MedicationID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HistoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код відвідування";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 117;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AppDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата відвідування";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 114;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn3.DataSource = this.patientBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пацієнт";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "PatientID";
            this.dataGridViewTextBoxColumn3.Width = 71;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn4.DataSource = this.doctorBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "DoctorName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Лікар";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "DoctorID";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DiseaseID";
            this.dataGridViewTextBoxColumn5.DataSource = this.diseaseBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "DiseaseName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Хвороба";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "DiseaseID";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Запис";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 63;
            // 
            // formMedUses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.сontraindicationsDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medUsesDataGridView);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.historyBindingNavigator);
            this.Name = "formMedUses";
            this.Text = "Призначення ліків";
            this.Load += new System.EventHandler(this.formMedUses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingNavigator)).EndInit();
            this.historyBindingNavigator.ResumeLayout(false);
            this.historyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medUsesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontraindicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medUsesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontraindicationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource historyBindingSource;
        private System.Windows.Forms.BindingNavigator historyBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.BindingSource diseaseBindingSource;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource medUsesBindingSource;
        private System.Windows.Forms.DataGridView medUsesDataGridView;
        private System.Windows.Forms.BindingSource medicationBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource сontraindicationsBindingSource;
        private System.Windows.Forms.DataGridView сontraindicationsDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxMedicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}