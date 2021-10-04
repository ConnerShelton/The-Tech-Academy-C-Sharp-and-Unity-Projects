using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mthdsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.FirstName = "Sample";
            Employee.LastName = "Student";

            Employee.SayName();
        }
    }
}
