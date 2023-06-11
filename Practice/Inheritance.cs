using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Inheritance
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }

            public Person(string firstname, string lastname, string gender)
            {
                firstname = FirstName;
                lastname = LastName;
                gender = Gender;
            }

            //public Person() // either create a parameterless constructor
            //{ }
        }

        public class JyeMing : Person
        {
            // or do like this in the derived class
            public JyeMing(string firstname, string lastname, string gender) : base(firstname, lastname, gender)
            {
            }
        }
    }
}
