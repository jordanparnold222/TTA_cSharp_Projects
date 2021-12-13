using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment1
{
    class Person
    {
        public string FirstName = "Jordan";
        public string LastName = "Arnold";

        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
