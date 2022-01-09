using StudentDatabase.DataModels;
using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Jordan" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }

        }
    }
}
