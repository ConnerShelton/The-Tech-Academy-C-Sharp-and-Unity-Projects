using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations.Add(3, 7);

            Operations.Add(9.25m, 5.75m);

            Operations.Add("7", "13");

            Console.ReadLine();
        }
    }
}
