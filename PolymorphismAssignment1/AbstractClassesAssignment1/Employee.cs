using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment1
{
    //enheriting from the abstract "person" class
    class Employee : Person, IQuittable
    {

        //Adding to the SawName Method that was inhereted
        public override void SayName()
        {
            Console.WriteLine("Employee name:");
            base.SayName();
        }

        //Adding functionality to the Quit method that was inhereted from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("You quit your job");
            Console.ReadLine();
        }
    }
}
