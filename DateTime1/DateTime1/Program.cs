using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Showing current date and time
            Console.WriteLine("The current time is: " + DateTime.Now);
            Console.ReadLine();

            //getting user input, to add to the current time
            Console.WriteLine("Enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());


            //adding that input as hours to the current date and time
            Console.WriteLine("Wow. That is " + DateTime.Now.AddHours(answer) + " if we added that to the current time as hours.");
            Console.ReadLine();
        }
    }
}
