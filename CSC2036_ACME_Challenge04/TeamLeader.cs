
namespace CSC2036_ACME_Challenge04
{
    public class TeamLeader : ProductionWorker
    {
        private double monthlyBonus;
        private int requiredTraining;
        private int earnedTraining;
        public double MonthlyBonus { get; set; }
        public int RequiredTraining { get; set; }
        public int EarnedTraining { get; set; }

        public TeamLeader() {} // Default constructor
        public TeamLeader(int empNumber, string empName, double hourlyRate, 
            int shiftNumber, double monthlyBonus, int requiredTraining, 
            int earnedTraining) : base(empNumber, empName, hourlyRate, shiftNumber)
        {
            this.monthlyBonus = monthlyBonus;
            this.requiredTraining = requiredTraining;
            this.earnedTraining = earnedTraining;
        }
        public TeamLeader(string empAndInfo)
        {
            string[] columns = empAndInfo.Split(sep);
            int len = columns.Length;

            // Set Employee number
            if (len > 0) 
                if (columns[0] != "")
                    this.EmpNumber = Convert.ToInt32(columns[0]);
                else this.EmpNumber = 0;
            else this.EmpNumber = 0;

            // Set Employee name
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


            // Set Monthly Bonus
            if (len > 4) 
                if (columns[4] != "") 
                    this.MonthlyBonus = Convert.ToDouble(columns[4]);
                else this.MonthlyBonus = 0.0;
            else this.MonthlyBonus = 0.0;


            // Set Required Training
            if (len > 5) 
                if (columns[5] != "")
                    this.RequiredTraining = Convert.ToInt32(columns[5]);
                else this.RequiredTraining = 0;
            else this.RequiredTraining = 0;

            // Set Earned Training
            if (len > 6) 
                if (columns[6] != "")
                    this.EarnedTraining = Convert.ToInt32(columns[6]);
                else this.EarnedTraining = 0;
            else this.EarnedTraining = 0;
        }

        public override string GetDisplayText() => base.GetDisplayText() 
            + sep + "Team Leader" + sep + Convert.ToString(this.MonthlyBonus) 
            + sep + Convert.ToString(this.RequiredTraining) + sep 
            + Convert.ToString(this.EarnedTraining);
        
    }
}
