using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            int[] myNum = { 15, 25, 35, 45 };

            //CAR ARRAY
            Console.WriteLine("Please input the Index location code of the data you need.");
            int carIndex = Convert.ToInt32(Console.ReadLine());
            if (carIndex >= 0 && carIndex <= 3)
            {
                Console.WriteLine(cars[carIndex]);
                Console.ReadLine();
            }

            //No data available msg
            else
            {
                Console.WriteLine("Sorry but the number you selected does not seem to exist!");
                Console.WriteLine("Have a Good Day!!!");
                Console.ReadLine();
            }

            //NUM ARRAY

            Console.WriteLine("Please input the Index location code of the data you need.");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            if (numIndex >= 0 && numIndex <= 3)
            {
                Console.WriteLine(myNum[numIndex]);
                Console.ReadLine();
            }

            //No data available msg
            else
            {
                Console.WriteLine("Sorry but the number you selected does not seem to exist!");
                Console.WriteLine("Have a Good Day!!!");
                Console.ReadLine();
            }

            //LIST

            List<string> intList = new List<string>();

            intList.Add("Hello");
            intList.Add("Conner");
            intList.Add("Boo");
            //list use
            Console.WriteLine("Please input the location code of the data you need.");
            Console.WriteLine("Input should be a number such as: 2");

            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex >= 0 && listIndex <= 2)
            {
                Console.WriteLine(intList[listIndex]);
                Console.ReadLine();
            }

            //No data available msg
            else
            {
                Console.WriteLine("Sorry but the number you selected does not seem to exist!");
                Console.WriteLine("Have a Good Day!!!");
                Console.ReadLine();
            }
        }
    }
}
