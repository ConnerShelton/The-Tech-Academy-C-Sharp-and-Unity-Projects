using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        //Name propertys
        public static string firstName { get; set; }
        public static string lastName { get; set; }

        //method SayName
        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}
