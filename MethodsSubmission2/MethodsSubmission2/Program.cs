using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class
            someMethods methods = new someMethods();

            //Getting input for the one required parameter
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + 3 equals: {1}", num1, methods.Adding(num1));
            Console.ReadLine();

            //Giving the user the option to modify the second parameter from its default value
            Console.WriteLine("Enter a second number if you want. This isn't required.");
            string num2 = Console.ReadLine();

            //Determining whether or not the user decided to re-run the method with its second parameter modified
            if (num2 != "")
            {
                int num2Conv = Convert.ToInt32(num2);

                Console.WriteLine("{0} plus {1} equals {2}", num1, num2Conv, methods.Adding(num1, num2Conv));
                Console.Read();
            }
            else
            {
                Console.WriteLine("Alright, have a nice day.");
                Console.Read();
            }
        }
    }
}
