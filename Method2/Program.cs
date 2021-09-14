using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first variable of your choice(Cannot be blank)");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second variable of your choice(Can be blank)");
            string Y = Console.ReadLine();

            if (int.TryParse(Y, out int y))
            {
                Operator.Add(x, y);
            }
            else
            {
                Operator.Add(x);
            }

            Console.ReadLine();
        }
    }
}
