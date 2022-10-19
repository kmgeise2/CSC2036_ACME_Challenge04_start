using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC2036_ACME_Challenge04
{
    public class ProductionWorker : Employee
    {
        private double hourlyRate;
        private int shiftNumber;

        public double HourlyRate
        {
            get
            {
                return this.hourlyRate;
            }
            set
            {
                this.hourlyRate = value;
            }
        }
        public int ShiftNumber
        {
            get
            {
                return this.shiftNumber;
            }
            set
            {
                this.shiftNumber = value;
            }
        }

        public ProductionWorker() 
        {
            // Default constructor
        }
        public ProductionWorker(int empNumber, string empName, 
            double hourlyRate, int shiftNumber) : base(empNumber, empName)
        {
            this.hourlyRate = hourlyRate;
            this.shiftNumber = shiftNumber;
        }
        public override string GetDisplayText() => base.GetDisplayText() 
            + sep + "Production Worker" + sep 
            + Convert.ToString(this.hourlyRate) + sep 
            + Convert.ToString(this.shiftNumber);
        public ProductionWorker(string empAndInfo)
        {
            string[] columns = empAndInfo.Split(sep);
            int len = columns.Length;

            // Set employee number
            if (len > 0) 
                if (columns[0] != "")
                    this.EmpNumber = Convert.ToInt32(columns[0]);
                else this.EmpNumber = 0;
            else this.EmpNumber = 0;

            // Set employee name
            if (len > 1) 
                if (columns[1] != "")
                    this.EmpName = columns[1];
                else this.EmpName = "";
            else this.EmpName = "";

            // Set Hourly Rate
            if (len > 2)  
                if (columns[2] != "")
                    this.HourlyRate = Convert.ToDouble(columns[2]);
                 else this.HourlyRate = 0.0;
            else this.HourlyRate = 0.0;

            // Set Shift Number
            if (len > 3) 
                if (columns[3] != "")
                    this.ShiftNumber = Convert.ToInt32(columns[3]);
                else this.ShiftNumber = 0;
            else this.ShiftNumber = 0;
        }
    }
}
