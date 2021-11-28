using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //STRING ARRAY SECTION
            bool isValid = false;

            //runs the loop until the isValid bool is switched to "true"
            while (!isValid)
            {
                string[] strArray = { "cat", "dog", "mouse", "hamster", "chicken" };

                Console.WriteLine("Enter a number (must be within range 0 and 4) and I will print the word associated to that index.");
                int index1 = Convert.ToInt32(Console.ReadLine());

                //checks that the user entered an index numbers that exists
                if (index1 == 0 || index1 == 1 || index1 == 2 || index1 == 3 || index1 == 4)
                {
                    Console.WriteLine(strArray[index1]);
                    isValid = true;
                    Console.ReadLine();


                }
                //restarts the loop to allow the user to enter a correct value
                else
                {
                    Console.WriteLine("Sorry, that is not a correct number. Try again.");
                }

            }


            //INT ARRAY SECTION
            isValid = false;

            //runs the loop until the isValid bool is switched to "true"
            while (!isValid)
            {
                int[] intArray = { 22, 33, 44, 55, 66 };

                Console.WriteLine("Enter a number (must be within range 0 and 4)and I will print the integer associated to that index.");
                int index1 = Convert.ToInt32(Console.ReadLine());

                //checks that the user entered an index numbers that exists
                if (index1 == 0 || index1 == 1 || index1 == 2 || index1 == 3 || index1 == 4)
                {
                    Console.WriteLine(intArray[index1]);
                    isValid = true;
                    Console.ReadLine();


                }
                //restarts the loop to allow the user to enter a correct value
                else
                {
                    Console.WriteLine("Sorry, that is not a correct number. Try again.");
                }



            }
            //STRING LIST SECTION
            isValid = false;

            //runs the loop until the isValid bool is switched to "true"
            while (!isValid)
            {
                List<string> strList =new List<string> { "John", "Sally", "Bertha", "Nemo", "Gerald" };

                Console.WriteLine("Enter a number (must be within range 0 and 4)and I will print the name associated to that index.");
                int index1 = Convert.ToInt32(Console.ReadLine());

                //checks that the user entered an index numbers that exists
                if (index1 == 0 || index1 == 1 || index1 == 2 || index1 == 3 || index1 == 4)
                {
                    Console.WriteLine(strList[index1]);
                    isValid = true;
                    Console.ReadLine();


                }
                //restarts the loop to allow the user to enter a correct value
                else
                {
                    Console.WriteLine("Sorry, that is not a correct number. Try again.");
                }



            }
        }
    }
}
