using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Please enter a radius");

            string radiusString = Console.ReadLine();
            int.TryParse(radiusString, out int radius);

            Console.WriteLine($"The square of the round {Program.PerformCalculation(radius)}");

            Console.ReadKey();

            long a = 20;
            long b = 30;
            Sum((int)a, (int)b);

        }

        static void Sum(int a, int b)
        {

        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            
            decimal square = Pi * r * r;

            return square;
        }
    }
}
