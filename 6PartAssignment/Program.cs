using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////PART 1
            ////Create Array
            //string[] Greetings = { "Good Morning!", "Good Day!", "Good Afternoon!", "Good Evening!" };

            ////Receive User Input to utilize with Array
            //Console.WriteLine("Please Insert Text Below");
            //Console.WriteLine("Then Press Enter");
            //string userIn = Console.ReadLine();

            ////Create loop to connect Array to Input
            //foreach (string i in Greetings)
            //{
            //    Console.WriteLine(i + userIn);
            //    Console.ReadLine();
            //}

            ////Part 2
            ////Fixed Infinite Loop and Using < operator
            ////for (int i = 0; i > -1; i++) //Created infinite loop, commented out to fix below
            //for (int i = 1; i < 21; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            ////Part 3
            ////loop using <= operator
            //for (int z = 1; z <= 28; z++)
            //{
            //    Console.WriteLine(z);
            //}
            //Console.WriteLine("There are 29 Printable lines in the Console Pop-Up");
            //Console.ReadLine();

            //LIST FOR PART 4, 5, and 6
            List<string> stringList = new List<string>();

            stringList.Add("Baldur");
            stringList.Add("Baldur");
            stringList.Add("Frigg");
            stringList.Add("Hel");
            stringList.Add("Odin");
            stringList.Add("Loki");
            stringList.Add("Heimdallur");
            stringList.Add("Thor");
            stringList.Add("Thor");
            stringList.Add("Mimir");
            stringList.Add("Magni");
            stringList.Add("Idunn");
            stringList.Add("Freyr");
            stringList.Add("Sif");
            stringList.Add("Fenrir");
            stringList.Add("Sleipnir");
            stringList.Add("Jormungandr");
            stringList.Add("Huginn");
            stringList.Add("Odin");
            stringList.Add("Odin");
            stringList.Add("Yggdrasil");

            //Part 4

            ////begining of parsing list block
            //bool c = false;
            //Console.WriteLine("Insert the item you are searching for");
            //string input = Console.ReadLine();
            //int j = -1;
            //foreach (String temp in stringList)
            //{
            //    c = input.Equals(temp);
            //    j++;
            //    if (c)
            //        break;
            //}

            //if (c)
            //{
            //    Console.WriteLine(j);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.Write("Your input is not on the list.");
            //    Console.ReadLine();
            //}


            ////Part 5

            ////begining of parsing list block
            //Console.WriteLine("Insert the item you are searching for");
            //string input = Console.ReadLine();
            //int j = 0;
            //foreach (String temp in stringList)
            //{
            //    if (temp.Contains(input))
            //    {
            //        Console.WriteLine(j);
            //        Console.ReadLine();
            //    }
            //    j++;
            //}

            //if (j == 21)
            //{
            //    Console.Write("Your input is not on the list.");
            //    Console.ReadLine();
            //}


            //Part 6

            Console.WriteLine("this is the data in our list");
            foreach (String temp in stringList)
            {
                Console.WriteLine(temp);
                if (stringList.Count != stringList.Distinct().Count())
                {
                    Console.WriteLine("This is NOT a duplicate");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("This is a duplicate");
                    Console.ReadLine();
                }
            }

        }
    }
}
