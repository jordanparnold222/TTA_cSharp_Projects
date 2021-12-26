using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determines whether the loop continues
            bool validAge = false;
            while (!validAge)
            {
                //attempt to recieve a proper age
                try
                {
                    Console.WriteLine("Hi, how old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 1) throw new InvalidAgeException();

                    //If the input was valid, the program will continue as planned
                    else
                    {
                        int year = 2021 - age;
                        Console.WriteLine("Ah, so you were born in {0}.", year);
                        Console.ReadLine();
                        validAge = true;
                    }

                }
                //Catching for an input value of less than 1
                catch (InvalidAgeException)
                {
                    Console.WriteLine("That is not physically possible. Try again.");
                    Console.ReadLine();

                }
                //catching any other exception that wasn't already explicitely stated.
                catch (Exception)
                {
                    Console.WriteLine("Not sure what happened there. Let's try again.");
                    Console.ReadLine();
                }


            }
           

        }
    }
}
