using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiply by 50
            Console.WriteLine("Enter a number and watch me multiply it by 50: ");
            int mult50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((mult50 * 50) + "!");
            Console.ReadLine();


            //Add 25
            Console.WriteLine("Give me a number to add 25 to: ");
            int plus25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((plus25 + 25) + "!");
            Console.ReadLine();


            //Divide by 12.5
            Console.WriteLine("Give me a number to divide my 12.5: ");
            double div125 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((div125 / 12.5) + "!");
            Console.ReadLine();


            //Check if greater than 50
            Console.WriteLine("Give me a number to see whether or not it is greater than 50: ");
            int comp = Convert.ToInt32(Console.ReadLine());
            bool comp50 = comp > 50;
            Console.WriteLine("This is " + comp50.ToString() + "!");
            Console.ReadLine();

            //Divide by 7 and give the remainder
            Console.WriteLine("Give me a number to divide by 7, then give you the remainder: ");
            int theNumber = Convert.ToInt32(Console.ReadLine());
            int rem7 = theNumber % 7;
            Console.WriteLine(rem7 + "!");
            Console.ReadLine();


        }
    }
}
