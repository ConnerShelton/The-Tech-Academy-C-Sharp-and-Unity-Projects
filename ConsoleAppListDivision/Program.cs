using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppListDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            intList.Add(20);
            intList.Add(20);
            intList.Add(20);
            intList.Add(20);
            intList.Add(20);

            Console.WriteLine("Enter a number to divide by!");
            int input = Convert.ToInt32(Console.ReadLine());

            foreach (int temp in intList)
            {
                try
                {
                    Console.WriteLine(temp + " divided by " + input + " equals:");
                    Console.WriteLine(temp / input);
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("What you enterd was 0 or not a number at all, please try again!");
                }
                Console.WriteLine("TRY/CATCH: SUCCESSFUL"); 
            }
            Console.ReadLine();
        }
    }
}
