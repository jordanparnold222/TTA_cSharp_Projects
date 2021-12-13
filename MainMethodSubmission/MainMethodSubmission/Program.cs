using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the methods class I created
            MethodClass1 methods = new MethodClass1();

            //Utilizing 1st instance of Adding method
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of adding that number to itself is: {0}", methods.Adding(num1));
            Console.ReadLine();

            //Utilizing the 2nd instance of Adding method but including the second argument
            Console.WriteLine("Now enter a second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("When adding this number to the first number, after rounding, we get: {0}", methods.Adding(num1, num2));
            Console.ReadLine();

            //Utilizing the 3rd instance of Adding method by also including the optional string variable
            Console.WriteLine("Now enter a third number");
            string num3 = Console.ReadLine();

            Console.WriteLine("When adding the third number to the other two, we get: {0}", methods.Adding(num1, num2, num3));
            Console.ReadLine();
        }
    }
}
