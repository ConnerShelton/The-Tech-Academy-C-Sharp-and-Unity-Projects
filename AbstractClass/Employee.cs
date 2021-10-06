using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittalbe
    {
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

        public static Person operator== (Employee x, Employee y)
        {
            
            return y;
        }

        public static Person operator!= (Employee x, Employee y)
        {

            return y;
        }
    }
}
