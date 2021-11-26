using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping_quote
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome section and checking weight qualification
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            //what happens if the weight falls within the guidelines
            else
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());

                int total = width + height + length;

                //checking for package dimensions qualification
                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                //cost gets calculated if the dimensions falls within the guidelines
                else
                {
                    double cost = (height * width * length * weight) / 100;

                    Console.WriteLine("Your cost to ship this package is $" + cost);
                    Console.ReadLine();
                }
            }
        }
    }
}
