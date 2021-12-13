using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    class someMethods
    {
        //first method
        public void divByTwo(int num1)
        {
           int result = num1 / 2;

            Console.WriteLine("{0} divided by 2 is: {1}", num1, result);
            Console.ReadLine();
        }


        //2nd method, which demonstrates overloading and utilizing an out parameter
        public void divByTwo(int num1, out int result,int divideBy = 2)
        {
            result = num1 / divideBy;

            Console.WriteLine("{0} divided by {1} is: {2}", num1, divideBy, result);
            Console.ReadLine();
        }
    }
}
