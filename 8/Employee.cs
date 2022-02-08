using System;
namespace MEmp {
    public class Employee {
        string FirstName;
        string LastName;
        double MonthlySalary;
        public Employee(string fname, string lname, double monsalary) {
            FirstName = fname;
            LastName = lname;
            MonthlySalary = monsalary;
        }
        public string fname {
            get => FirstName;
            set => FirstName = value;
        }
        public string lname {
            get => LastName;
            set => LastName = value;
        }
        public double monsalary {
            get => MonthlySalary;
            set => MonthlySalary = value < 0 ? 0.0 : value;
        }
        public virtual void giveRaise(double raise) {
            MonthlySalary = MonthlySalary + (MonthlySalary * raise / 100);
        }
        public override string ToString() {
            return $"FIRST NAME:{FirstName}\nLAST NAME: {LastName} \nSALARY : {MonthlySalary*12}";
        }
    }
    public class Permanentemployee: Employee {
        double HRA;
        double DA;
        double ProvidentFund;
        string JoiningDate;
        string RetirementDate;
        public Permanentemployee(string FirstName, string LastName, string JD, string RD, double MonthlySalary, double housingRentAllowance, double dearnessAllowance, double proviFund): base(FirstName, LastName, MonthlySalary) {
            this.HRA = housingRentAllowance;
            this.DA = dearnessAllowance;
            this.ProvidentFund = proviFund;
            this.JoiningDate = JD;
            this.RetirementDate = RD;
            this.monsalary = this.monsalary + HRA + DA;
        }
        public double housingRentAllowance {
            get => HRA;
        }
        public double dearnessAllowance {
            get => DA;
        }
        public double proviFund {
            get => ProvidentFund;
        }
        public string JD {
            get => JoiningDate;
            set => JoiningDate = value;
        }
        public string RD {
            get => RetirementDate;
            set => RetirementDate = value;
        }
        public override void giveRaise(double raise) {
            this.monsalary = this.monsalary + (this.monsalary * raise) / 100 + DA + HRA;
        }
        public override string ToString() {
            return $"{base.ToString()}\nJOINING DATE:{JoiningDate} \nRETIREMENT DATE:{RetirementDate}";
        }
    }
}