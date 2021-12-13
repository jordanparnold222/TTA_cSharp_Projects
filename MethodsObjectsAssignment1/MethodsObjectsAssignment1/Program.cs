using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an object of the Person class
            Person person = new Person();

            //Calling the function that prints the name properties
            person.SayName();

            //Instantiating an object of the employee class
            Employee employee = new Employee();

            //Modifying the default name properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Calling on the SayName function that was inherited from the Person class
            employee.SayName();
        }
    }
}
