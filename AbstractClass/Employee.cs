using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittalbe
    {
        //unsure how to create a list of Id #'s in this context.
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("The Employee Named '" + firstName + 
                " " + lastName + "' has Quit!");
            Console.ReadLine();
        }

        public static bool operator== (Employee x, Employee y)
        {
            if (Id1 == Id2)
            {
                //writeline function

            }
            return y;
        }

        public static bool operator!= (Employee x, Employee y)
        {
            if (Id1 != Id2)
            {
                //continue function

            }
            return y;
        }
    }
}
