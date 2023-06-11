using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DependencyInjection_WithDependencyInversion
    {
        public interface IEmployeeDAL
        {
            // interface can contain properties, but cannot contain fields
            List<Employee> SelectAllEmployees();
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        // dependency object (Service)
        public class EmployeeDAL: IEmployeeDAL
        {
            public List<Employee>SelectAllEmployees()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee(){Id = 1, Name = "Jyeming", Department = "IT"},
                    new Employee(){Id = 1, Name = "Zhunyee", Department = "IT"}
                };
                return employees;
            }
        }

        //inversion of control by creating a factory class to create new object EmployeeDAL
        //public class EMployeeDALFactory
        //{
        //    public static EmployeeDAL GetEmployeeDALObject()
        //    {
        //        return new EmployeeDAL();
        //    }
        //}

        // dependent object (Client)
        // depends on abstraction now
        public class EmployeeBL
        {
            //inversion of control
            //EmployeeDAL _employeeDAL;
            //public void GetAllEmployees()
            //{
            //    _employeeDAL = EMployeeDALFactory.GetEmployeeDALObject();
            //    _employeeDAL.SelectAllEmployees();
            //}


            // below codes are tightly coupled, not recommended to use. 
            //EmployeeDAL empDAL;
            //public List<Employee>SelectAllEmployees()
            //{
            //    return empDAL.SelectAllEmployees(); // tight coupling because EmployeeDAL tightly coupled with the EmployeeBL class.
            //}


            IEmployeeDAL _employeeDAL;                  // dependency inversion 

            public EmployeeBL(IEmployeeDAL iEmployeeDAL) // dependency injection - constructor injection
            {
                _employeeDAL = iEmployeeDAL;
            }

            public List<Employee> GetAllEmployees()
            {
                List<Employee> getEmployees = _employeeDAL.SelectAllEmployees();
                return getEmployees;
            }

        }
        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        EmployeeBL empBL = new EmployeeBL(new EmployeeDAL());
        //        List<Employee> getEmployee = empBL.GetAllEmployees();
        //        foreach (Employee emp in getEmployee)
        //        {
        //            Console.WriteLine("EmployeeID: {0}, Employee Name: {1}, Employee Department: {2}", emp.Id, emp.Name, emp.Department);
        //        }
        //    }
        //}
    }
}
