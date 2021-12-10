using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John ", "Sally ", "Mark ", "Rebecca " };

            Console.WriteLine("Hi, I have some first names that need a last name attached to them. \nPlease give me a last name:");
            string lastName = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + lastName;

            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "\n");
            }
            Console.ReadLine();

            //infinite loop

            for (int i = 2; i < 1; i++)
            {
                Console.WriteLine("Uh oh, i'm and infinit loop and i don't want to be infinite. Please help me!");
            }
            Console.ReadLine();

            //PART 4
            List<string> fruits = new List<string> { "apple", "banana", "mango" };
            Console.WriteLine("Please enter the name of a fruit and I will see if i have any:");
            string query = Console.ReadLine();
            bool keepSearching = false;

            for (int x = 0; x < (fruits.Count) || keepSearching == false; x++)
            {
                if (fruits[x].Contains(query))
                {
                    Console.WriteLine(fruits[x]);
                    keepSearching = true;

                }

                if ((keepSearching == false) && (x == (fruits.Count - 1)))
                {
                    Console.WriteLine("Sorry, I don't have that fruit.");
                    keepSearching = true;
                }

            }
            Console.ReadLine();

            //PART 5

            //Initial list
            List<string> languages = new List<string> { "English", "Spanish", "French", "Italian", "French" };

            Console.WriteLine("Enter a language and I'll show whether it's in my list and I'll display the index it is in.");
            string language = Console.ReadLine();

            bool endIt = false;
            int amount = 0;

            for (int x = 0; x <= languages.Count || endIt == false; x++)
            {


                if (x < languages.Count && languages[x].Contains(language))
                {
                    Console.WriteLine(x);
                    amount++;
                }
                else if ((x == languages.Count) && (amount == 0))
                {
                    Console.WriteLine("Sorry, my list does not contain your input.");
                    endIt = true;
                }
                else { endIt = true; }
            }
            Console.ReadLine();


            //PART 6 

            //Initial list
            List<string> foods = new List<string> { "taco", "burger", "taco", "hotdog" };


            foreach (string food in foods)
            {
            
                int instanceCount = 0;



//running through the list for instance amounts
                for (int x = 0; x < 4; x++)
                {
                    if (foods[x].Contains(food))
                    {
                        instanceCount++;
                    }
                }
                //determines whether there are multiple instances and prints the resulting message
                bool moreThanOne = instanceCount > 1;

                if (moreThanOne == true)
                {
                    Console.WriteLine("There is more than one instance of " + food + " in this list.");
                }
                else
                {
                    Console.WriteLine("There is NOT more than one instance of " + food + " in this list.");
                }
                

            }
            Console.ReadLine();


        }
    }
}
