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
            //1st employee instantiation and assignning of values
            Employee emp1 = new Employee();

            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.ID = 1;

            //2nd employee instantiation and assignning of values
            Employee emp2 = new Employee();
            emp2.firstName = "Student";
            emp2.lastName = "Sample";
            emp2.ID = 1;


            //testing the == overload I created in the employee class
            Console.WriteLine(emp2 == emp1);
            Console.ReadLine();





            //*****EVERYTHING BELOW THIS IS IRRELEVANT TO THE CURRENT SUBMISSION*****//



            ////calling the "sayname" function that was inhereted from the abstract "person" class
            //emp1.SayName();

            ////Using polymorphism to instantiate an object that has the type IQuittable
            //IQuittable IQuit = new Employee();

            //List<Employee> emp = new List<Employee>();


           
            //IQuit.Quit();
        }
    }
}
