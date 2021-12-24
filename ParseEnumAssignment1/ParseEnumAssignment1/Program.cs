using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseEnumAssignment1
{
    class Program
    {
        //Instantiating the enum
        public enum DaysOfWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        };
        static void Main()
        {
            //prompting user to enter a day of the week
            Console.WriteLine("Please enter a day of the week.");
            string beforeAnswer = Console.ReadLine();
            //automatically makes the variable lowercase to avoid unnecessary errors
            string afterAnswer = beforeAnswer.ToLower();

                try
                {
                //parses for matching enum value
                    DaysOfWeek weekday = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), afterAnswer);
                    Console.WriteLine("Yes, {0} is a day of the week", afterAnswer);
                    Console.ReadLine();
                }
                catch (ArgumentException ex)
                {
                //informs user if they entered a day of the week that doesn't exist
                    Console.WriteLine("Please enter an actual day of the week");
                    Console.ReadLine();
                }









        }

    }
}
