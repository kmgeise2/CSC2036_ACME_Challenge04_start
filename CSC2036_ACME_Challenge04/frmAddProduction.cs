using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CSC2036_ACME_Challenge04
{
    public partial class frmAddProduction : Form
    {
        public frmAddProduction()
        {
            InitializeComponent();
        }
        private Employee? employee = null;

        public Employee GetNewEmployee()
        {
            this.ShowDialog();
            return employee;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                employee = new ProductionWorker(Convert.ToInt32(txtEmpNumber.Text), txtEmpName.Text,
                    Convert.ToDouble(txtHourlyRate.Text), Convert.ToInt32(txtShiftNumber.Text));
                this.Tag = employee;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtEmpNumber.Text, txtEmpNumber.Tag.ToString());
            errorMessage += Validator.IsPresent(txtEmpName.Text, txtEmpName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtHourlyRate.Text, txtHourlyRate.Tag.ToString());
            errorMessage += Validator.IsPresent(txtShiftNumber.Text, txtShiftNumber.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
}
