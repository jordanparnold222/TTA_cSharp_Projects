using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the class
            someMethods methods = new someMethods();

            //Prompting for 1st variable input
            Console.WriteLine("Enter the first number");
            int numb1 = Convert.ToInt32(Console.ReadLine());

            //Prompting for 2nd variable input
            Console.WriteLine("Enter the second number");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            //Calling the method without specifying the parameter names
            methods.someMath(numb1, numb2);

            //Calling the method while specifying the parameter names
            methods.someMath(num1: numb1, num2: numb2);
            Console.ReadLine();
        }
    }
}
