namespace CSC2036_ACME_Challenge04
{
    partial class frmAddProduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShiftNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number";
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Location = new System.Drawing.Point(461, 70);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(300, 55);
            this.txtEmpNumber.TabIndex = 1;
            this.txtEmpNumber.Tag = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(460, 179);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(512, 55);
            this.txtEmpName.TabIndex = 3;
            this.txtEmpName.Tag = "Employeer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hourly Rate";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(457, 294);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(300, 55);
            this.txtHourlyRate.TabIndex = 5;
            this.txtHourlyRate.Tag = "Hourly Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift Number";
            // 
            // txtShiftNumber
            // 
            this.txtShiftNumber.Location = new System.Drawing.Point(451, 404);
            this.txtShiftNumber.Name = "txtShiftNumber";
            this.txtShiftNumber.Size = new System.Drawing.Size(300, 55);
            this.txtShiftNumber.TabIndex = 7;
            this.txtShiftNumber.Tag = "Shift Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(280, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 69);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(566, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 69);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 687);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtShiftNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduction";
            this.Text = "Add Production Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtEmpNumber;
        private Label label2;
        private TextBox txtEmpName;
        private Label label3;
        private TextBox txtHourlyRate;
        private Label label4;
        private TextBox txtShiftNumber;
        private Button btnSave;
        private Button btnCancel;
    }
}