using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC2036_ACME_Challenge04
{
    public class ShiftSupervisor : Employee
    {
        private double annualSalary;
        private double annualBonus;

        public ShiftSupervisor()
        {
        }
        public ShiftSupervisor(int empNumber, string empName, double annualSalary, double annualBonus) : base(empNumber, empName)
        {
            this.annualSalary = annualSalary;
            this.annualBonus = annualBonus;
        }

        public ShiftSupervisor(string empAndInfo)
        {
            string[] columns = empAndInfo.Split(sep);

            // Set employee number
            if (columns[0] != "")
                this.EmpNumber = Convert.ToInt32(columns[0]);
            else
                this.EmpNumber = 0;

            // Set employee name
            if (columns[1] != "")
                this.EmpName = columns[1];
            else
                this.EmpName = "";

            // Set Annual Salary
            if (columns[2] != "")
                this.AnnualSalary = Convert.ToDouble(columns[2]);
            else
                this.AnnualSalary = 0.0;

            // Set Annual Bonus
            if (columns[3] != "")
                this.AnnualBonus = Convert.ToDouble(columns[3]);
            else
                this.AnnualBonus = 0.0;
        }

        public double AnnualSalary 
        {
            get
            {
                return this.annualSalary;
            } 
            set
            {
                this.annualSalary = value;
            }
        }
        public double AnnualBonus 
        {
            get
            {
                return this.annualBonus;
            }
            set
            {
                this.annualBonus = value;
            } 
        }

        public override string GetDisplayText() => base.GetDisplayText() + sep + "Shift Supervisor" + sep + Convert.ToString(this.annualSalary) + sep + Convert.ToString(this.annualBonus);
    
    }
}
