using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMEthods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting user to enter the number
            Console.WriteLine("Hi, enter a number and I will perform 3 math operations on it.");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());

            //Displaying the results of the methods called from the someMethods class
            Console.WriteLine("Your number after doubling it is: " + someMethods.Doubling(chosenNumber));
            Console.WriteLine("Your number after being cut in half is: " + someMethods.Half(chosenNumber));
            Console.WriteLine("Your number after multiplying it by itself is: " + someMethods.MultByItself(chosenNumber));
            Console.Read();
        }
    }
}
