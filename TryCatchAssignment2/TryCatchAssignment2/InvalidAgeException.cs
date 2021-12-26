using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment2
{
    //Inhereting from the 'Exception' class so that it can mimics its behavior
    public class InvalidAgeException : Exception
    {
        //creating the constructor for use in the main program.
        public InvalidAgeException()
            : base() { }
        public InvalidAgeException(string message)
            : base(message) { }
    }
}
