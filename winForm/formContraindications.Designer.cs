
namespace winForm
{
    partial class formContraindications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formContraindications));
            this.contraindicationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contraindicationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contraindicationDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.contraindicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxPatientID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxMedicationID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationBindingNavigator)).BeginInit();
            this.contraindicationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contraindicationBindingNavigator
            // 
            this.contraindicationBindingNavigator.AddNewItem = null;
            this.contraindicationBindingNavigator.BindingSource = this.contraindicationBindingSource;
            this.contraindicationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contraindicationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contraindicationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contraindicationBindingNavigatorSaveItem});
            this.contraindicationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contraindicationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contraindicationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contraindicationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contraindicationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contraindicationBindingNavigator.Name = "contraindicationBindingNavigator";
            this.contraindicationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contraindicationBindingNavigator.Size = new System.Drawing.Size(417, 25);
            this.contraindicationBindingNavigator.TabIndex = 0;
            this.contraindicationBindingNavigator.Text = "bindingNavigator1";
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
            // contraindicationBindingNavigatorSaveItem
            // 
            this.contraindicationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contraindicationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contraindicationBindingNavigatorSaveItem.Image")));
            this.contraindicationBindingNavigatorSaveItem.Name = "contraindicationBindingNavigatorSaveItem";
            this.contraindicationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contraindicationBindingNavigatorSaveItem.Text = "Save Data";
            this.contraindicationBindingNavigatorSaveItem.Click += new System.EventHandler(this.contraindicationBindingNavigatorSaveItem_Click);
            // 
            // contraindicationDataGridView
            // 
            this.contraindicationDataGridView.AutoGenerateColumns = false;
            this.contraindicationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.contraindicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contraindicationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxPatientID,
            this.dataGridViewComboBoxMedicationID});
            this.contraindicationDataGridView.DataSource = this.contraindicationBindingSource;
            this.contraindicationDataGridView.Location = new System.Drawing.Point(20, 43);
            this.contraindicationDataGridView.Name = "contraindicationDataGridView";
            this.contraindicationDataGridView.Size = new System.Drawing.Size(347, 187);
            this.contraindicationDataGridView.TabIndex = 1;
            this.contraindicationDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.contraindicationDataGridView_DefaultValuesNeeded);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(292, 248);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // contraindicationBindingSource
            // 
            this.contraindicationBindingSource.DataSource = typeof(modeling.Models.Contraindication);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(modeling.Models.Patient);
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataSource = typeof(modeling.Models.Medication);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ContraindicationID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ContraindicationID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 119;
            // 
            // dataGridViewComboBoxPatientID
            // 
            this.dataGridViewComboBoxPatientID.DataPropertyName = "PatientID";
            this.dataGridViewComboBoxPatientID.DataSource = this.patientBindingSource;
            this.dataGridViewComboBoxPatientID.DisplayMember = "LastName";
            this.dataGridViewComboBoxPatientID.HeaderText = "Пацієнт";
            this.dataGridViewComboBoxPatientID.Name = "dataGridViewComboBoxPatientID";
            this.dataGridViewComboBoxPatientID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxPatientID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxPatientID.ValueMember = "PatientID";
            this.dataGridViewComboBoxPatientID.Width = 71;
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
            this.dataGridViewComboBoxMedicationID.Width = 54;
            // 
            // formContraindications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 283);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.contraindicationDataGridView);
            this.Controls.Add(this.contraindicationBindingNavigator);
            this.Name = "formContraindications";
            this.Text = "Протипоказання";
            this.Load += new System.EventHandler(this.formContraindications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationBindingNavigator)).EndInit();
            this.contraindicationBindingNavigator.ResumeLayout(false);
            this.contraindicationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contraindicationBindingSource;
        private System.Windows.Forms.BindingNavigator contraindicationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contraindicationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView contraindicationDataGridView;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource medicationBindingSource;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxPatientID;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxMedicationID;
    }
}