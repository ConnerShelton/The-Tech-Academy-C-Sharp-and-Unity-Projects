using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.firstName = "Sample";
            Employee.lastName = "Student";

            Employee employee = new Employee();

            employee.SayName();
            employee.Quit();

            //veiw results
            Console.ReadLine();
        }
    }
}
