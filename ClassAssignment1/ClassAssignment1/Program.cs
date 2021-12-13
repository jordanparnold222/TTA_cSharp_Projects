using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int outParam;

            //instantiating an object of the "someMethods" class
            someMethods methods = new someMethods();

            //prompts for user input
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            methods.divByTwo(num1);

            //prompts for second input to use in the overloaded class
            Console.WriteLine(" Enter another number to divide with the first one you typed");
            int num2 = Convert.ToInt32(Console.ReadLine());
            methods.divByTwo(num1, out outParam, num2);

            //demonstrating that I successfully used an out parameter to assign a value to a variable within this class
            Console.WriteLine("This statement is going to display a variable who's value was acquired via the out parameter: {0}", outParam);
            Console.ReadLine();

            //Demonstrating calling a method from a static class
            moreMethods.divByTwo(10);
        }
    }
}
