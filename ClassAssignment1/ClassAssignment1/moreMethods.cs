using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    //The static class portion of this assignment
    static class moreMethods
    {
        static public void divByTwo(int num1)
        {
            int result = num1 / 2;

            Console.WriteLine("{0} divided by 2 is: {1}", num1, result);
            Console.WriteLine("This method was called without having to instantiate an object, because the class is static.");
            Console.ReadLine();
        }
    }
}
