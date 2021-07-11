using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int p1Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int p1Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int p2Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int p2Hours = Convert.ToInt32(Console.ReadLine());

            int p1Weekly = p1Rate * p1Hours;
            int p2Weekly = p2Rate * p2Hours;

            int p1Salary = p1Weekly * 52;
            int p2Salary = p2Weekly * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1Salary);
            

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2Salary);
            

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1Salary > p2Salary);
            Console.ReadLine();
        }
    }
}
