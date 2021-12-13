using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMEthods
{
    public static class someMethods
    {
        //doubling method
        public static int Doubling(int num1)
        {
            int num2 = num1 * 2;
            return num2;
        }

        //halfing method
        public static int Half(int num1)
        {
            int num2 = num1 / 2;
            return num2;
        }

        //squaring method
        public static int MultByItself(int num1)
        {
            int num2 = num1 + num1;
            return num2;
        }
    }
}
