using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask Age
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());

            //DUI Check
            Console.WriteLine("Have you ever had a DUI?(Please answer 'true' or 'false')");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            //Ticket Check
            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());

            //Qualification Check
            bool Qualifies = (Age > 15 && DUI == false && Tickets<3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualifies);
            Console.ReadLine();
        }
    }
}
