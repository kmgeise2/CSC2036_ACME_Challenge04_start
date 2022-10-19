namespace CSC2036_ACME_Challenge04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPW = new System.Windows.Forms.Button();
            this.btnAddSS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 48;
            this.listBoxEmployee.Location = new System.Drawing.Point(44, 46);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(979, 388);
            this.listBoxEmployee.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1087, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(225, 69);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1086, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 69);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1083, 307);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 69);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPW
            // 
            this.btnAddPW.Location = new System.Drawing.Point(98, 468);
            this.btnAddPW.Name = "btnAddPW";
            this.btnAddPW.Size = new System.Drawing.Size(225, 173);
            this.btnAddPW.TabIndex = 4;
            this.btnAddPW.Text = "Add Production Worker";
            this.btnAddPW.UseVisualStyleBackColor = true;
            this.btnAddPW.Click += new System.EventHandler(this.btnAddPW_Click);
            // 
            // btnAddSS
            // 
            this.btnAddSS.Location = new System.Drawing.Point(415, 478);
            this.btnAddSS.Name = "btnAddSS";
            this.btnAddSS.Size = new System.Drawing.Size(225, 163);
            this.btnAddSS.TabIndex = 5;
            this.btnAddSS.Text = "Add Shift Supervisor";
            this.btnAddSS.UseVisualStyleBackColor = true;
            this.btnAddSS.Click += new System.EventHandler(this.btnAddSS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 163);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Team Leader";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 787);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddSS);
            this.Controls.Add(this.btnAddPW);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listBoxEmployee);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxEmployee;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExit;
        private Button btnAddPW;
        private Button btnAddSS;
        private Button button1;
    }
}