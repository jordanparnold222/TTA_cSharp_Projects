using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment1
{
    //instantiation of the abstract "person" class
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //prints the person's first and last name to the screen
        public void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
