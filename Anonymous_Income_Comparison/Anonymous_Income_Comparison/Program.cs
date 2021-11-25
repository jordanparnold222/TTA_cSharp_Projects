using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            Console.WriteLine("Anonymous Income Comparison Program");

            //BEGIN ACQUIRING PERSON 1 INFO
            Console.WriteLine("Person 1: ");

            Console.WriteLine("(Person 1) What is your hourly rate?");
            double p1HourRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("(Person 1) How many hours do you work per week?");
            double p1HoursWorked = Convert.ToDouble(Console.ReadLine());



            //BEGIN ACQUIRING PERSON 1 INFO
            Console.WriteLine("Person 2: ");

            Console.WriteLine("(Person 2) What is your hourly rate?");
            double p2HourRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("(Person 2) How many hours do you work per week?");
            double p2HoursWorked = Convert.ToDouble(Console.ReadLine());



            //PRINTING ANNUAL SALARIES OF EACH PERSON

            double anSal1 = (p1HourRate * p1HoursWorked) * 52;
            double anSal2 = (p2HourRate * p2HoursWorked) * 52;
            bool p1MakesMore = anSal1 > anSal2;

            Console.WriteLine("Person 1's annual salary: ");
            Console.WriteLine("$" + anSal1);
            Console.WriteLine("");
            Console.WriteLine("Person 2's annual salary: ");
            Console.WriteLine("$" + anSal2);
            Console.WriteLine("");
            Console.ReadLine();

            //Specifying whether or not person 1 makes more than person 2
            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.WriteLine(p1MakesMore.ToString());
            Console.ReadLine();
        }
    }
}
