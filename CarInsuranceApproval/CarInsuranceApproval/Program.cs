using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for age input
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //asks for dui history input
            Console.WriteLine("Have you ever had a DUI? Please reply with either \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            //asks for speeding ticket count input
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());


            //calculates whether the user is qualified
            bool qualified = (age > 15) && (dui == false) && (tickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
