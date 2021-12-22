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
            //Creating the first list and populating it
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee("Jordan", "Arnold", 001));
            emps.Add(new Employee("Joe", "Johnson", 002));
            emps.Add(new Employee("Joe", "Jerry", 003));
            emps.Add(new Employee("Sally", "McSally", 004));
            emps.Add(new Employee("Lilly", "Pad", 005));
            emps.Add(new Employee("Hoover", "McDuver", 006));
            emps.Add(new Employee("Ben", "Smith", 007));
            emps.Add(new Employee("Sarah", "Palin", 008));
            emps.Add(new Employee("Fredrick", "Baker", 009));
            emps.Add(new Employee("Rick", "Webb", 010));

            //Creating the 2nd list
            List<Employee> empJoe = new List<Employee>();

            //populating a list of employees named "Joe"
            foreach (Employee emp in emps)
            {
                if (emp.firstName == "Joe")
                {
                    empJoe.Add(emp);
                    Console.WriteLine(emp.firstName);
                }
            }


            //creating new list of employees who's ID is greater than 5, using a lambda function
            List<Employee> empID = emps.Where(x => x.ID > 5).ToList();
            Console.WriteLine(empID[0].firstName);
            Console.ReadLine();








            //*****EVERYTHING BELOW THIS IS IRRELEVANT TO THE CURRENT SUBMISSION*****//


            ////1st employee instantiation and assignning of values
            //Employee emp1 = new Employee();

            //emp1.firstName = "Sample";
            //emp1.lastName = "Student";
            //emp1.ID = 1;

            ////2nd employee instantiation and assignning of values
            //Employee emp2 = new Employee();
            //emp2.firstName = "Student";
            //emp2.lastName = "Sample";
            //emp2.ID = 1;


            ////testing the == overload I created in the employee class
            //Console.WriteLine(emp2 == emp1);
            //Console.ReadLine();






            ////calling the "sayname" function that was inhereted from the abstract "person" class
            //emp1.SayName();

            ////Using polymorphism to instantiate an object that has the type IQuittable
            //IQuittable IQuit = new Employee();

            //List<Employee> emp = new List<Employee>();



            //IQuit.Quit();
        }
    }
}
