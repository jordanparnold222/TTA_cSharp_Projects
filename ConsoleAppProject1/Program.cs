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
            List<string> fruits = new List<string> {"apple", "banana", "mango" };
            Console.WriteLine("Please enter the name of a fruit and I will see if i have any:");
            string query = Console.ReadLine();
            bool keepSearching = true;

            for (int x = 0; x < fruits.Count || keepSearching == false; x++ )
            {
                 if (query == fruits[x])
                {
                    Console.WriteLine(fruits[x]);
                    keepSearching = false;

                }    

                if ((keepSearching == true) && (x == (fruits.Count - 1)))
                    {
                    Console.WriteLine("Sorry, I don't have that fruit.");
                }

            }
            Console.ReadLine();

            //PART 5 (Awaiting clarification. This is the email I sent to the instructor email:
            //For the "out of range" error, the program seems to function as intended however VS is throwing me this error.When I try to logically break down what that loop is doing, I end up coming to the conclusion that 'x' never has a chance to call on an index that is outside of the list's range. Am I seeing this incorrectly? 
            //For the image that shows step 5 of the challenge, I guess I'm just unsure on what is meant by a user 'selecting' text. 


            //PART 6 

            //Initial list
            List<string> foods = new List<string> { "taco", "burger", "taco", "hotdog" };

            foreach (string food in foods)
            {
                //Generating a new list to compare the original one to
                List<string> compareTo = new List<string>();
                compareTo.Add(food);

                //This bool will be triggered the message if turned to "true" due to repeat instances of a string
                bool isPresent = foods.Contains(food);


                //if-then statement to check whether there is a repeat string
                if (isPresent == true)
                {
                    Console.WriteLine("There is more than one instance of " + food + " in this list.");
                    Console.ReadLine();
                }
            }


        }
    }
}
