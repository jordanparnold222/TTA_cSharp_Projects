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
        public Employee(string firstName, string lastName, int ID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;

        }




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


    }
}
