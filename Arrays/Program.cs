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

            //initialize list
            List<string> intList = new List<string>();
            //Create list items
            intList.Add("Hello");
            intList.Add("Conner");
            intList.Remove("Conner");

            //Instructions for data use
            Console.WriteLine("Please input the location code of the data you need.");
            Console.WriteLine("Input should be a 'Base' and 'Item' number such as: 0-0");
            Console.WriteLine("'Bases': Cars = 0 ; Numbers = 1");
            Console.WriteLine("'Items(0)': Volvo = 0 ; BMW = 1 ; Ford = 2 ; Mazda = 3");
            Console.WriteLine("'Items(1)': 15 = 0 ; 25 = 1 ; 35 = 2 ; 45 = 3");
            string useArray = Console.ReadLine();

            //Cars array items
            if (useArray == "0-0")
            {
                Console.WriteLine(cars[0]);
                Console.ReadLine();
            }
            else if (useArray == "0-1")
            {
                Console.WriteLine(cars[1]);
                Console.ReadLine();
            }
            else if (useArray == "0-2")
            {
                Console.WriteLine(cars[2]);
                Console.ReadLine();
            }
            else if (useArray == "0-3")
            {
                Console.WriteLine(cars[3]);
                Console.ReadLine();
            }

            //Number array items
            else if (useArray == "1-0")
            {
                Console.WriteLine(myNum[0]);
                Console.ReadLine();
            }
            else if (useArray == "1-1")
            {
                Console.WriteLine(myNum[1]);
                Console.ReadLine();
            }
            else if (useArray == "1-2")
            {
                Console.WriteLine(myNum[2]);
                Console.ReadLine();
            }
            else if (useArray == "1-3")
            {
                Console.WriteLine(myNum[3]);
                Console.ReadLine();
            }

            //No data available msg
            else
            {
                Console.WriteLine("The location code you selected does not seem to exist!");
                Console.WriteLine("Have a Good Day!!!");
                Console.ReadLine();
            }

            //Instructions for list use
            Console.WriteLine("Please input the location code of the data you need.");
            Console.WriteLine("Input should be a number such as: 3");
            string useList = Console.ReadLine();

            //List items
            if (useList == "0")
            {
                Console.WriteLine(intList[0]);
                Console.ReadLine();
            }
            else if (useList == "1")
            {
                Console.WriteLine(intList[1]);
                Console.ReadLine();
            }
            else if (useList == "2")
            {
                Console.WriteLine(intList[2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The location code you selected does not seem to exist!");
                Console.WriteLine("Have a Good Day!!!");
                Console.ReadLine();
            }
        }
    }
}
