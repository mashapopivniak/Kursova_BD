
namespace winForm
{
    partial class formMeds
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
            System.Windows.Forms.Label medicationIDLabel;
            System.Windows.Forms.Label medicationNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMeds));
            this.medicationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.medicationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicationIDTextBox = new System.Windows.Forms.TextBox();
            this.medicationNameTextBox = new System.Windows.Forms.TextBox();
            this.medicationPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSourceInclude = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxIncludeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            medicationIDLabel = new System.Windows.Forms.Label();
            medicationNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingNavigator)).BeginInit();
            this.medicationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInclude)).BeginInit();
            this.SuspendLayout();
            // 
            // medicationIDLabel
            // 
            medicationIDLabel.AutoSize = true;
            medicationIDLabel.Location = new System.Drawing.Point(51, 37);
            medicationIDLabel.Name = "medicationIDLabel";
            medicationIDLabel.Size = new System.Drawing.Size(54, 13);
            medicationIDLabel.TabIndex = 1;
            medicationIDLabel.Text = "Код ліків:";
            // 
            // medicationNameLabel
            // 
            medicationNameLabel.AutoSize = true;
            medicationNameLabel.Location = new System.Drawing.Point(51, 73);
            medicationNameLabel.Name = "medicationNameLabel";
            medicationNameLabel.Size = new System.Drawing.Size(42, 13);
            medicationNameLabel.TabIndex = 3;
            medicationNameLabel.Text = "Назва:";
            // 
            // medicationBindingNavigator
            // 
            this.medicationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicationBindingNavigator.BindingSource = this.medicationBindingSource;
            this.medicationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicationBindingNavigatorSaveItem});
            this.medicationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicationBindingNavigator.Name = "medicationBindingNavigator";
            this.medicationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicationBindingNavigator.Size = new System.Drawing.Size(310, 25);
            this.medicationBindingNavigator.TabIndex = 0;
            this.medicationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataSource = typeof(modeling.Models.Medication);
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
            // medicationBindingNavigatorSaveItem
            // 
            this.medicationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicationBindingNavigatorSaveItem.Image")));
            this.medicationBindingNavigatorSaveItem.Name = "medicationBindingNavigatorSaveItem";
            this.medicationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicationBindingNavigatorSaveItem.Text = "Save Data";
            this.medicationBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicationBindingNavigatorSaveItem_Click);
            // 
            // medicationIDTextBox
            // 
            this.medicationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationBindingSource, "MedicationID", true));
            this.medicationIDTextBox.Location = new System.Drawing.Point(128, 34);
            this.medicationIDTextBox.Name = "medicationIDTextBox";
            this.medicationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationIDTextBox.TabIndex = 2;
            // 
            // medicationNameTextBox
            // 
            this.medicationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationBindingSource, "MedicationName", true));
            this.medicationNameTextBox.Location = new System.Drawing.Point(128, 70);
            this.medicationNameTextBox.Name = "medicationNameTextBox";
            this.medicationNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationNameTextBox.TabIndex = 4;
            // 
            // medicationPartsBindingSource
            // 
            this.medicationPartsBindingSource.DataMember = "MedicationParts";
            this.medicationPartsBindingSource.DataSource = this.medicationBindingSource;
            // 
            // medicationPartsDataGridView
            // 
            this.medicationPartsDataGridView.AutoGenerateColumns = false;
            this.medicationPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicationPartsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxIncludeID});
            this.medicationPartsDataGridView.DataSource = this.medicationPartsBindingSource;
            this.medicationPartsDataGridView.Location = new System.Drawing.Point(54, 109);
            this.medicationPartsDataGridView.Name = "medicationPartsDataGridView";
            this.medicationPartsDataGridView.Size = new System.Drawing.Size(200, 168);
            this.medicationPartsDataGridView.TabIndex = 5;
            this.medicationPartsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.medicationPartsDataGridView_DefaultValuesNeeded);
            // 
            // bindingSourceInclude
            // 
            this.bindingSourceInclude.DataSource = this.medicationBindingSource;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(179, 301);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MedicationPartID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MedicationPartID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MedicationID";
            this.dataGridViewTextBoxColumn2.HeaderText = "MedicationID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewComboBoxIncludeID
            // 
            this.dataGridViewComboBoxIncludeID.DataPropertyName = "IncludeID";
            this.dataGridViewComboBoxIncludeID.DataSource = this.bindingSourceInclude;
            this.dataGridViewComboBoxIncludeID.DisplayMember = "MedicationName";
            this.dataGridViewComboBoxIncludeID.HeaderText = "Компоненти";
            this.dataGridViewComboBoxIncludeID.Name = "dataGridViewComboBoxIncludeID";
            this.dataGridViewComboBoxIncludeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxIncludeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxIncludeID.ValueMember = "MedicationID";
            // 
            // formMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 344);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.medicationPartsDataGridView);
            this.Controls.Add(medicationNameLabel);
            this.Controls.Add(this.medicationNameTextBox);
            this.Controls.Add(medicationIDLabel);
            this.Controls.Add(this.medicationIDTextBox);
            this.Controls.Add(this.medicationBindingNavigator);
            this.Name = "formMeds";
            this.Text = "formMeds";
            this.Load += new System.EventHandler(this.formMeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingNavigator)).EndInit();
            this.medicationBindingNavigator.ResumeLayout(false);
            this.medicationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInclude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource medicationBindingSource;
        private System.Windows.Forms.BindingNavigator medicationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton medicationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox medicationIDTextBox;
        private System.Windows.Forms.TextBox medicationNameTextBox;
        private System.Windows.Forms.BindingSource medicationPartsBindingSource;
        private System.Windows.Forms.DataGridView medicationPartsDataGridView;
        private System.Windows.Forms.BindingSource bindingSourceInclude;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxIncludeID;
    }
}