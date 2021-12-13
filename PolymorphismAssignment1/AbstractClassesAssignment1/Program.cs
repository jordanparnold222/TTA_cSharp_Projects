using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an object of the "employee" class
            Employee emp1 = new Employee();

            //assigning values the the object's class attributes
            emp1.firstName = "Sample";
            emp1.lastName = "Student";

            //calling the "sayname" function that was inhereted from the abstract "person" class
            emp1.SayName();

            //Using polymorphism to instantiate an object that has the type IQuittable
            IQuittable IQuit = new Employee();

           
            IQuit.Quit();
        }
    }
}
