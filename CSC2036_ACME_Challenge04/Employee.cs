using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CSC2036_ACME_Challenge04
{
    public abstract class Employee
    //An abstract class is a class that can’t be instantiated.
    //It can be used only as a base class that other classes can inherit.
    {
        public string? empName;
        public int empNumber;
        public char sep = '|';

        public Employee()
        {
            // Default constructor
        }
        public Employee(int empNumber, string empName)
        {
            // This constructor receives data
            this.EmpNumber = empNumber;
            this.EmpName = empName;
        }
        // Default getters and setters
        public int EmpNumber { get; set; }
        public string? EmpName { get; set; } // Nullable 
        
        // The base method to format a string for the list box
        // This method will be overridden by every class
        public virtual string GetDisplayText() => Convert.ToString(EmpNumber) 
            + sep + EmpName;
    }
}
