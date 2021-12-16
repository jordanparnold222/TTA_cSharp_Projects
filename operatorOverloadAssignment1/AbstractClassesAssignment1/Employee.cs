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


        public int ID { get; set; }
        //Adding to the SayName Method that was inhereted
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


        //These next 2 overloads are for the == and != operators to compare 2 employees based off ther ID numbers
        public static bool operator ==(Employee emp1, Employee emp2)
        {


            return emp1.ID == emp2.ID;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {


            return emp1.ID != emp2.ID;
        }
    }
}
