using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class InversionControl
    {
        // tightly coupled
        public class EmployeeBusinessLogic
        {
            //DataAccess _dataAccess; 

            //public void GetCustomerName()
            //{
            //    _dataAccess.GetEmployeeData();
            //}

            public void GetCustomerName()
            {
                // we use DataAccessFactory class to create object of DataAccess.
                DataAccess _dataAccess = DataAccessFactory.GetDataAccessObject();
                _dataAccess.GetEmployeeData();
            }
            
        }
    }

    public class DataAccess
    {
        public void GetEmployeeData()
        {
            Console.WriteLine("Here you go for employees data.");
        }
    }

    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObject()
        {
            return new DataAccess();
        }
    }
}
