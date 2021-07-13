using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SimpleWhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int q = 0;
            //while (q < 5)
            //{
            //    Console.WriteLine(q);
            //    q++;
            //}

            //Console.ReadLine();

            int z = 0;
            do
            {
                Console.WriteLine(z);
                z++;
            }
            while (z < 5);

            Console.ReadLine();
        }
    }
}
