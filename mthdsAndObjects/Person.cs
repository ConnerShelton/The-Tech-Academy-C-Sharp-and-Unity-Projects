using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mthdsAndObjects
{
    class Person
    {
        //Name propertys
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        //method SayName
        public static void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
