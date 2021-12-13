using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class MethodClass1
    {
        //Original method
        public int Adding(int num1)
        {
            int num2 = num1 + num1;
            return num2;
        }

        //2nd method when the double argument is passed in
        public int Adding(int num1, double num2)
        {
            int result = num1 + Convert.ToInt32(num2);
            return result;
        }

        //3rd method when all 3 possible arguments are passed in
        public int Adding(int num1, double num2, string num3)
        {
            int strToNum = Convert.ToInt32(num3);
            int result = num1 + Convert.ToInt32(num2) + strToNum;
            return result;
        }
    }
}
