
namespace CSC2036_ACME_Challenge04
{
    public partial class Form1 : Form
    {
        public List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ProductionWorker employee1 = new ProductionWorker("123|John Doe|15|1");
            ShiftSupervisor employee2 = new ShiftSupervisor("234|Jane Eyre|65000|2000");
            TeamLeader employee3 = new TeamLeader("345|Billy Bob|15|2|50|20|2");
            //
            // Load employee list
            //
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            LoadEmployeeListBox();
        }
        private void LoadEmployeeListBox()
        {
            //Clear the list box
            listBoxEmployee.Items.Clear();

           // Add the employees from the list to the listbox
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = employees[i];
                listBoxEmployee.Items.Add(employee.GetDisplayText());
            }

            //Set the selected index to zero
            if (listBoxEmployee.Items.Count > 0)
                listBoxEmployee.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPW_Click(object sender, EventArgs e)
        {
            // Create an instance of the Add New Production Worker Form
            frmAddProduction f1 = new frmAddProduction();
            DialogResult button = f1.ShowDialog();

            // Retrieve information if OK is clicked
            if (button == DialogResult.OK)
            {
                employees.Add((ProductionWorker)f1.Tag);
                LoadEmployeeListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = listBoxEmployee.SelectedIndex;
            if (i != -1)
            {
                Employee employee = employees[i];
                string message = "Are you sure you want to delete "
                    + employee.EmpName + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    listBoxEmployee.Items.RemoveAt(i);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = listBoxEmployee.SelectedIndex;
            if (i != -1)
            {
                Employee employee = employees[i];
                Type type = employee.GetType();
                if (type.Name == "ProductionWorker")
                {
                    ProcessProduction(i, employee);
                }
                else if (type.Name == "ShiftSupervisor")
                {
                    ProcessShift(i, employee);
                }
                else if (type.Name == "TeamLeader")
                {
                    ProcessLeader(i, employee);
                }
                else 
                { 
                    // Do nothing
                }
            }
        }

        private void ProcessProduction(int i, Employee employee)
        {
            // Create an instance of the Update Production Worker Form
            // Use the Tag field to pass the current employee
            frmUpdateProduction f1 = new frmUpdateProduction();
            f1.Tag = employee;
            DialogResult button = f1.ShowDialog();

            // Retrieve information if OK is clicked
            // Dialog Result is a property of the Save button
            // Set the Dialog Result to OK in the form designer
            if (button == DialogResult.OK)
            {
                try
                {
                    ProductionWorker tempEmployee = ((ProductionWorker)f1.Tag);
                    employees.RemoveAt(i);
                    employees.Insert(i, tempEmployee);
                }
                catch
                {
                    //Do nothing
                }

                LoadEmployeeListBox();
            }
        }
        private void ProcessShift(int i, Employee employee)
        {
            // Add this code
        }

        private void ProcessLeader(int i, Employee employee)
        {
            // Add this code
        }

        private void btnAddSS_Click(object sender, EventArgs e)
        {
            // Create an instance of the Add New Shift Supervisor Form
            frmAddShiftSupervisor f2 = new frmAddShiftSupervisor();
            DialogResult button = f2.ShowDialog();

            // Retrieve information if OK is clicked
            if (button == DialogResult.OK)
            {
                employees.Add((ShiftSupervisor)f2.Tag);
                LoadEmployeeListBox();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is the Add Team Leader click event
        }
    }
}