using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Methods
    {
        public void Multiply(int userIn)
        {
            Console.WriteLine(userIn * 8);
        }

        public void Divide(int userIn)
        {
            Console.WriteLine(userIn / 3);
        }

        public void Add(int userIn)
        {
            Console.WriteLine(userIn + 100);
        }
    }
}
