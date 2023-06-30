using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class INSCALEQuestion
    {
        public class CountCommissionEarned
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }    
            public double CommissionRate { get; set; }
            public int YearOfExperience { get; set; }

            public CountCommissionEarned(string firstname, string lastname, double commissionrate, int experience)
            {
                FirstName = firstname;
                LastName = lastname;
                CommissionRate = commissionrate;
                YearOfExperience = experience;
            }

            public virtual void CalculateCommission()
            {
                double commission = CommissionRate * YearOfExperience;
                Console.WriteLine("Your commission is: " + commission);
            }          
        }

        public class ChildCountCommissionEarned: CountCommissionEarned
        {
            public double Salary { get; set; }  
            public ChildCountCommissionEarned(string firstname, string lastname, double commisionrate, int experience, double baseSalary): base(firstname, lastname, commisionrate, experience)
            {
                this.Salary = baseSalary;
            }

            public override void CalculateCommission()
            {
                double yourSalary = Salary * CommissionRate;
                Console.WriteLine("Firstname: " + FirstName);
                Console.WriteLine("Lastname: " + LastName);
                Console.WriteLine("Commission Rate: " + CommissionRate);
                Console.WriteLine("Experience: " + YearOfExperience);
                Console.WriteLine("This is your total salary: " + yourSalary);
            }
        }
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        //CountCommissionEarned commissionearned = new CountCommissionEarned("Chan", "JyeMing", 0.1, 3);
        //        //commissionearned.CalculateCommission();
        //        ChildCountCommissionEarned countSalary1 = new ChildCountCommissionEarned("Chan", "JyeMing", 0.1, 3, 4000);
        //        countSalary1.CalculateCommission();
        //        ChildCountCommissionEarned countSalary2 = new ChildCountCommissionEarned("Ng", "Zhunyee", 0.1, 2, 4500);
        //        countSalary2.CalculateCommission();
        //        ChildCountCommissionEarned countSalary3 = new ChildCountCommissionEarned("Alice", "Wong", 0.1, 5, 6500);
        //        countSalary3.CalculateCommission();
        //    }
        //}
    }
}
