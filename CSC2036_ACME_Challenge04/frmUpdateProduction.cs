
namespace CSC2036_ACME_Challenge04
{
    public partial class frmUpdateProduction : Form
    {
        private Form1 _employeesForm1; // The field is the underscore variable 
        
        private ProductionWorker selectedEmployee;
        ProductionWorker tempEmployee = new ProductionWorker();   
        public frmUpdateProduction()
        {
            // Default constructor
            InitializeComponent();
        }
        public frmUpdateProduction(Form1 employeesForm) : this()
        {
            // This constructor accepts a passed form
            // Update the field reference with the passed form reference
            _employeesForm1 = employeesForm;
        }

        public frmUpdateProduction(ProductionWorker employeeData)
        {
            // This constructor accepts a passed ProductionWorker
            // Cast employee data into a new employee object
            ProductionWorker selectedEmployee = employeeData;
        }
        private void frmUpdateProduction_Load(object sender, EventArgs e)
        {
            // Employee data is passed through this form's Tag field
            // Map the tag data to the ProductionWorker class
            // All of the data must be converted to string to display
            //
            selectedEmployee = (ProductionWorker)this.Tag;

            txtEmpNumber.Text = Convert.ToString(selectedEmployee.EmpNumber);
            txtEmpName.Text = selectedEmployee.EmpName;
            txtHourlyRate.Text = Convert.ToString(selectedEmployee.HourlyRate);
            txtShiftNumber.Text = Convert.ToString(selectedEmployee.ShiftNumber);

        }
            private void label3_Click(object sender, EventArgs e)
        {
            //Ignore this click method
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tempEmployee.EmpNumber = Convert.ToInt32(txtEmpNumber.Text);
            tempEmployee.EmpName = txtEmpName.Text;
            tempEmployee.HourlyRate = Convert.ToDouble(txtHourlyRate.Text);
            tempEmployee.ShiftNumber = Convert.ToInt32(txtShiftNumber.Text);

            // Update the Tag field
            this.Tag = tempEmployee;

            // Close the form 
            this.Close();
        }
    }
}
