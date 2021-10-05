using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittalbe
    {
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
    }
}
