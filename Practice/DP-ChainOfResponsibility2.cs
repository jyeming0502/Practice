using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DP_ChainOfResponsibility2
    {
        public abstract class EmployeeLeaveHandler
        {
            public EmployeeLeaveHandler elh;
            public void SetNextApprover(EmployeeLeaveHandler empLeave)
            {
                elh = empLeave;
            }
            public abstract void ApproveLeave(string empName, int leaveApplied);
        }
        public class TeamLeader: EmployeeLeaveHandler
        {
            public int daysLeaveApprove { get; set; }
            public TeamLeader(int daysLeaveApprove): base()
            {
                this.daysLeaveApprove = daysLeaveApprove;
            }
            public override void ApproveLeave(string empName, int leaveApplied)
            {
                if (daysLeaveApprove > 10)
                {

                }
            }
        }
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Console.WriteLine("Please input number of days of leave Team Lead can approve");
        //        int daysLeave = int.Parse(Console.ReadLine());

        //    }
        //}
    }
}
