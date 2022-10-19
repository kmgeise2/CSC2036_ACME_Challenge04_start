namespace CSC2036_ACME_Challenge04
{
    partial class frmAddShiftSupervisor
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
            this.txtAnnualSalary = new System.Windows.Forms.TextBox();
            this.txtAnnualBonus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number";
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Location = new System.Drawing.Point(420, 67);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(300, 55);
            this.txtEmpNumber.TabIndex = 1;
            this.txtEmpNumber.Tag = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(415, 182);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(590, 55);
            this.txtEmpName.TabIndex = 3;
            this.txtEmpName.Tag = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Annual Salary";
            // 
            // txtAnnualSalary
            // 
            this.txtAnnualSalary.Location = new System.Drawing.Point(407, 289);
            this.txtAnnualSalary.Name = "txtAnnualSalary";
            this.txtAnnualSalary.Size = new System.Drawing.Size(300, 55);
            this.txtAnnualSalary.TabIndex = 5;
            this.txtAnnualSalary.Tag = "Annual Salary";
            // 
            // txtAnnualBonus
            // 
            this.txtAnnualBonus.Location = new System.Drawing.Point(410, 401);
            this.txtAnnualBonus.Name = "txtAnnualBonus";
            this.txtAnnualBonus.Size = new System.Drawing.Size(300, 55);
            this.txtAnnualBonus.TabIndex = 6;
            this.txtAnnualBonus.Tag = "Annual Bonus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Annual Bonus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAddShiftSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 696);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnnualBonus);
            this.Controls.Add(this.txtAnnualSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmAddShiftSupervisor";
            this.Text = "Add Shift Supervisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtEmpNumber;
        private Label label2;
        private TextBox txtEmpName;
        private Label label3;
        private TextBox txtAnnualSalary;
        private TextBox txtAnnualBonus;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}