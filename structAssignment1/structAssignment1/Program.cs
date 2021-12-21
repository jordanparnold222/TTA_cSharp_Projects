using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Number num = new Number();
            num.Amount = 2.3m;

            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
