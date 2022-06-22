
namespace winForm
{
    partial class formClinic
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMedications = new System.Windows.Forms.Button();
            this.Contraindications = new System.Windows.Forms.Button();
            this.buttonPatients = new System.Windows.Forms.Button();
            this.buttonDoctors = new System.Windows.Forms.Button();
            this.buttonSpecializations = new System.Windows.Forms.Button();
            this.buttonDiseases = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPatientDiseases = new System.Windows.Forms.Button();
            this.buttonMedUses = new System.Windows.Forms.Button();
            this.buttonHistories = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonpatientHistories = new System.Windows.Forms.Button();
            this.buttonDoctorWorkloads = new System.Windows.Forms.Button();
            this.buttondoctorPatients = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMedications);
            this.groupBox1.Controls.Add(this.Contraindications);
            this.groupBox1.Controls.Add(this.buttonPatients);
            this.groupBox1.Controls.Add(this.buttonDoctors);
            this.groupBox1.Controls.Add(this.buttonSpecializations);
            this.groupBox1.Controls.Add(this.buttonDiseases);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Довідники";
            // 
            // buttonMedications
            // 
            this.buttonMedications.Location = new System.Drawing.Point(18, 200);
            this.buttonMedications.Name = "buttonMedications";
            this.buttonMedications.Size = new System.Drawing.Size(113, 23);
            this.buttonMedications.TabIndex = 5;
            this.buttonMedications.Text = "Ліки";
            this.buttonMedications.UseVisualStyleBackColor = true;
            this.buttonMedications.Click += new System.EventHandler(this.buttonMedications_Click_1);
            // 
            // Contraindications
            // 
            this.Contraindications.Location = new System.Drawing.Point(18, 240);
            this.Contraindications.Name = "Contraindications";
            this.Contraindications.Size = new System.Drawing.Size(113, 23);
            this.Contraindications.TabIndex = 5;
            this.Contraindications.Text = "Протипоказання";
            this.Contraindications.UseVisualStyleBackColor = true;
            this.Contraindications.Click += new System.EventHandler(this.Contraindications_Click);
            // 
            // buttonPatients
            // 
            this.buttonPatients.Location = new System.Drawing.Point(18, 78);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(113, 23);
            this.buttonPatients.TabIndex = 3;
            this.buttonPatients.Text = "Пацієнти";
            this.buttonPatients.UseVisualStyleBackColor = true;
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            // 
            // buttonDoctors
            // 
            this.buttonDoctors.Location = new System.Drawing.Point(18, 162);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Size = new System.Drawing.Size(113, 23);
            this.buttonDoctors.TabIndex = 2;
            this.buttonDoctors.Text = "Лікарі";
            this.buttonDoctors.UseVisualStyleBackColor = true;
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // buttonSpecializations
            // 
            this.buttonSpecializations.Location = new System.Drawing.Point(18, 119);
            this.buttonSpecializations.Name = "buttonSpecializations";
            this.buttonSpecializations.Size = new System.Drawing.Size(113, 23);
            this.buttonSpecializations.TabIndex = 1;
            this.buttonSpecializations.Text = "Спеціалізації";
            this.buttonSpecializations.UseVisualStyleBackColor = true;
            this.buttonSpecializations.Click += new System.EventHandler(this.buttonSpecializations_Click);
            // 
            // buttonDiseases
            // 
            this.buttonDiseases.Location = new System.Drawing.Point(18, 34);
            this.buttonDiseases.Name = "buttonDiseases";
            this.buttonDiseases.Size = new System.Drawing.Size(113, 23);
            this.buttonDiseases.TabIndex = 0;
            this.buttonDiseases.Text = "Хвороби";
            this.buttonDiseases.UseVisualStyleBackColor = true;
            this.buttonDiseases.Click += new System.EventHandler(this.buttonDiseases_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPatientDiseases);
            this.groupBox2.Controls.Add(this.buttonMedUses);
            this.groupBox2.Controls.Add(this.buttonHistories);
            this.groupBox2.Location = new System.Drawing.Point(255, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оперативна інформація";
            // 
            // buttonPatientDiseases
            // 
            this.buttonPatientDiseases.Location = new System.Drawing.Point(18, 78);
            this.buttonPatientDiseases.Name = "buttonPatientDiseases";
            this.buttonPatientDiseases.Size = new System.Drawing.Size(113, 23);
            this.buttonPatientDiseases.TabIndex = 3;
            this.buttonPatientDiseases.Text = "Хвороби пацієнтів";
            this.buttonPatientDiseases.UseVisualStyleBackColor = true;
            this.buttonPatientDiseases.Click += new System.EventHandler(this.buttonPatientDiseases_Click);
            // 
            // buttonMedUses
            // 
            this.buttonMedUses.Location = new System.Drawing.Point(18, 119);
            this.buttonMedUses.Name = "buttonMedUses";
            this.buttonMedUses.Size = new System.Drawing.Size(113, 23);
            this.buttonMedUses.TabIndex = 1;
            this.buttonMedUses.Text = "Призначення ліків";
            this.buttonMedUses.UseVisualStyleBackColor = true;
            this.buttonMedUses.Click += new System.EventHandler(this.buttonMedUses_Click);
            // 
            // buttonHistories
            // 
            this.buttonHistories.Location = new System.Drawing.Point(18, 34);
            this.buttonHistories.Name = "buttonHistories";
            this.buttonHistories.Size = new System.Drawing.Size(113, 23);
            this.buttonHistories.TabIndex = 0;
            this.buttonHistories.Text = "Історії хвороб";
            this.buttonHistories.UseVisualStyleBackColor = true;
            this.buttonHistories.Click += new System.EventHandler(this.buttonHistories_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonpatientHistories);
            this.groupBox3.Controls.Add(this.buttonDoctorWorkloads);
            this.groupBox3.Controls.Add(this.buttondoctorPatients);
            this.groupBox3.Location = new System.Drawing.Point(479, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 280);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Звіти";
            // 
            // buttonpatientHistories
            // 
            this.buttonpatientHistories.Location = new System.Drawing.Point(18, 78);
            this.buttonpatientHistories.Name = "buttonpatientHistories";
            this.buttonpatientHistories.Size = new System.Drawing.Size(138, 23);
            this.buttonpatientHistories.TabIndex = 3;
            this.buttonpatientHistories.Text = "Історії хвороб пацієнтів";
            this.buttonpatientHistories.UseVisualStyleBackColor = true;
            this.buttonpatientHistories.Click += new System.EventHandler(this.buttonpatientHistories_Click);
            // 
            // buttonDoctorWorkloads
            // 
            this.buttonDoctorWorkloads.Location = new System.Drawing.Point(18, 119);
            this.buttonDoctorWorkloads.Name = "buttonDoctorWorkloads";
            this.buttonDoctorWorkloads.Size = new System.Drawing.Size(138, 23);
            this.buttonDoctorWorkloads.TabIndex = 1;
            this.buttonDoctorWorkloads.Text = "Завантаженість лікарів";
            this.buttonDoctorWorkloads.UseVisualStyleBackColor = true;
            this.buttonDoctorWorkloads.Click += new System.EventHandler(this.buttonDoctorWorkloads_Click);
            // 
            // buttondoctorPatients
            // 
            this.buttondoctorPatients.Location = new System.Drawing.Point(18, 34);
            this.buttondoctorPatients.Name = "buttondoctorPatients";
            this.buttondoctorPatients.Size = new System.Drawing.Size(138, 23);
            this.buttondoctorPatients.TabIndex = 0;
            this.buttondoctorPatients.Text = "Пацієнти лікарів";
            this.buttondoctorPatients.UseVisualStyleBackColor = true;
            this.buttondoctorPatients.Click += new System.EventHandler(this.buttondoctorPatients_Click);
            // 
            // formClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formClinic";
            this.Text = "Поліклініка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDiseases;
        private System.Windows.Forms.Button buttonSpecializations;
        private System.Windows.Forms.Button Contraindications;
        //private System.Windows.Forms.Button buttonMedications;
        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Button buttonDoctors;
        private System.Windows.Forms.Button buttonMedications;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPatientDiseases;
        private System.Windows.Forms.Button buttonMedUses;
        private System.Windows.Forms.Button buttonHistories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonpatientHistories;
        private System.Windows.Forms.Button buttonDoctorWorkloads;
        private System.Windows.Forms.Button buttondoctorPatients;
    }
}

