using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Operations
    {
        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public static void Add(decimal x, decimal y)
        {
            decimal answer = x + y;
            Console.WriteLine("$" + answer);
        }

        public static void Add(string x, string y)
        {
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);

            int answer = X + Y;
            Console.WriteLine(answer);
        }
    }
}
