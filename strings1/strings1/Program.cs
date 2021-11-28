using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Begins concatination and prints each new iteration
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, my name is Jordan.\n");
            Console.WriteLine(sb);
            Console.ReadLine();

            //first
            sb.Append("You are currently experiencing the superpower I'm weilding.\n");
            Console.WriteLine(sb);
            Console.ReadLine();

            //second
            sb.Append("Behold, the almighty...\n");
            Console.WriteLine(sb);
            Console.ReadLine();

            //third
            sb.Append("C O N C A T I N A T I O N !");
            Console.WriteLine(sb);
            Console.ReadLine();

            //converting it to a string and printing the uppercase version of it
            string toStr = sb.ToString();

            Console.WriteLine(toStr.ToUpper());
            Console.ReadLine();
        }
    }
}
