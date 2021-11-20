using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTa_Survey
{
    class Program
    {
        static void Main()
        {   //Intro text
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

         
         //~~~Information requested and stored into variables~~~
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pNum = int.Parse(Console.ReadLine());

            //This variable required casting to properly store the answer as a boolean value
            Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positives = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string altFB = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int HrsStudied = int.Parse(Console.ReadLine());

            //Conclusion of the Daily Report
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
 


        }
    }
}
