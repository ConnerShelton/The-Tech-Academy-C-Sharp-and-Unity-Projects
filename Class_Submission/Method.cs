using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    public class Method
    {
        public static void Divide(string userIn)
        {
            int num = Convert.ToInt32(userIn);
            int answer = num / 2;
            Console.WriteLine(answer);
        }

        public static void Divide(string userIn, int myIn)
        {
            Console.WriteLine("User input was not an integer");
            Console.WriteLine("Here is a number to cover for you: " + myIn);
            int num = myIn;
            int answer = num / 2;
            Console.WriteLine(answer);
        }
        public void Divide(string userIn, out int myIn)
        {
            myIn = 20;
            Console.WriteLine(userIn + myIn);
        }
    }

    
}
