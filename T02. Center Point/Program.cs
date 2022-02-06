using System;

namespace T02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintTheClosestToTheCenter(x1, y1, x2, y2);
        }

        static void PrintTheClosestToTheCenter(double x1, double y1, double x2, double y2)
        {
            double firstValue = Math.Abs(x1) + Math.Abs(y1);
            double secondValue = Math.Abs(x2) + Math.Abs(y2);

            if (firstValue <= secondValue)
            {
                Console.WriteLine($"({x1}, {y1})");   
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
