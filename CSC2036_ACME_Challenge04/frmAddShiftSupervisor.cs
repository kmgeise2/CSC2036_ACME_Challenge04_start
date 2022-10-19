using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC2036_ACME_Challenge04
{
    public partial class frmAddShiftSupervisor : Form
    {
        public frmAddShiftSupervisor()
        {
            InitializeComponent();
        }
        private Employee? employee = null;

        public Employee GetNewEmployee()
        {
            this.ShowDialog();
            return employee;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtEmpNumber.Text, txtEmpNumber.Tag.ToString());
            errorMessage += Validator.IsPresent(txtEmpName.Text, txtEmpName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtAnnualSalary.Text, txtAnnualSalary.Tag.ToString());
            errorMessage += Validator.IsPresent(txtAnnualBonus.Text, txtAnnualBonus.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                employee = new ShiftSupervisor(Convert.ToInt32(txtEmpNumber.Text), txtEmpName.Text,
                    Convert.ToDouble(txtAnnualSalary.Text), Convert.ToDouble(txtAnnualBonus.Text));
                this.Tag = employee;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
