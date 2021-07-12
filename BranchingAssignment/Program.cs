using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package's Weight.");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is your package's Height.");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your package's Length.");
                int pkgLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your package's Width.");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());

                if (pkgHeight + pkgLength + pkgWidth > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    int shipPrice = (((pkgHeight * pkgLength * pkgWidth) * pkgWeight) / 100);
                    Console.WriteLine("The total cost for shipping your package is: " + shipPrice + ".00");
                    Console.WriteLine("Thank you Come Again!");
                    Console.ReadLine();
                }
                
            }
        }
    }
}
