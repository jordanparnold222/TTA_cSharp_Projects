using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant variable
            const string name = "Jordan";
            //implicit variable
            var thing = "thing";

            //Testing the make sure C# recognized the implicit data type
            Console.WriteLine(thing.GetType());
            Console.ReadLine();

            //Testing the constructors
            Person person1 = new Person();
            Person person2 = new Person("John", 75);
            Console.WriteLine(person1.name + " " + person1.age);
            Console.WriteLine(person2.name + " " + person2.age);
            Console.ReadLine();


        }
    }
}
