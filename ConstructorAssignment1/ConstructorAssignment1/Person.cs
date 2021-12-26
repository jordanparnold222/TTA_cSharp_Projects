using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment1
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }


        //Chained constructor
        public Person () : this("Jordan", 25)
        {

        }
        //Original constructor
        public Person(string theName, int theAge)
        {
            name = theName;
            age = theAge;
        }
    }
}
