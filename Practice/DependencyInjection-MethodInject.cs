using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DepedencyInjection_MethodInject
    {
        public interface IEmployeeDAL
        {
            public List<Employee> GetAllEmployees();
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }
        public class EmployeeDAL : IEmployeeDAL
        {
            public List<Employee> GetAllEmployees()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee() {ID = 1, Name = "Jyeming", Department = "IT"},
                    new Employee() {ID = 2, Name = "Zhunyee", Department = "IT"},
                };
                return employees;
            }
        }

        public class EmployeeBL
        {
            public List<Employee> SelectAllEmployees(IEmployeeDAL employee)
            {
                List<Employee>getEmp = employee.GetAllEmployees();
                return getEmp;
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        EmployeeBL employeeBL = new EmployeeBL();
        //        List<Employee> empEmp = employeeBL.SelectAllEmployees(new EmployeeDAL());
        //        foreach(Employee emp in empEmp)
        //        {
        //            Console.WriteLine("EmployeeID: {0}, Employee Name: {1}, Employee Department: {2}", emp.ID, emp.Name, emp.Department);
        //        }
        //    }
        //}
    }
}
