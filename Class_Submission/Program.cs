using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    static class Program
    {
        static void Main(string[] args)
        {
            //int userIn = Convert.ToInt32(Console.ReadLine());

            

            Console.Write("Please Enter a Number: ");
            string userIn = Console.ReadLine(); //get input
            int myIn = 0;

            Method name = new Method();

            if (!int.TryParse(userIn, myIn))
            {
                Method.Divide(userIn, 18);
            }
            else
            {
                Method.Divide(userIn);
            }

            Console.ReadLine();
        }
    }
}
