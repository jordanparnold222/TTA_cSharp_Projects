using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_strings_integers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theList = new List<int> { 1, 2, 3, 4, 5 };



            //asking user to input the integer
            Console.WriteLine("Please enter a number and I will divide it by each number in a list I have.");
            int number = Convert.ToInt32(Console.ReadLine());


            //informing user that we are entering the try-catch block
            Console.WriteLine("We are now entering the try/catch block.");
            Console.ReadLine();

            //try-catch section
            try
            {

                foreach (int x in theList)
                {
                    Console.WriteLine(x / number);
                }
                Console.ReadLine();

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.ReadLine();
            }
            //informing the user that they sucessfully made it through the try-catch block
            Console.WriteLine("We have emerged from the try/catch block unscathed.");
            Console.ReadLine();


        }
    }
}
