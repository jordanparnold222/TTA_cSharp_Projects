using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGuessed = false;
            while (!isGuessed)
            {
                Console.WriteLine("Do I like apples, or oranges?");
                string guess = Console.ReadLine();

                switch (guess)
                {
                    case "apples":
                        Console.WriteLine("Nope, I do not like apples. Try again.");
                        break;

                    case "oranges":
                        Console.WriteLine("Correct! You win.");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Not even close. Try again.");
                        break;
                }
            }





            Console.WriteLine("Guess the magical number that I made up");
            int number = Convert.ToInt32(Console.ReadLine());
            isGuessed = number == 12;


            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("You guessed 2. Try again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("You guessed 3. Try again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("You guessed 4. Correct!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are so very wrong. Try again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();
        }
    }
}
