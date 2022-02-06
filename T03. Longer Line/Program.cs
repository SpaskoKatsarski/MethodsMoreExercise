using System;

namespace T03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintTheBiggerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintTheBiggerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (FindLengthOfFirstDouble(x1, y1, x2, y2) >= FindLengthOfSecondDouble(x3, y3, x4, y4))
            {
                PrintTheLineInCorrectOrder(x1, y1, x2, y2);
            }
            else
            {
                PrintTheLineInCorrectOrder(x3, y3, x4, y4);
            }
        }

        static double FindLengthOfFirstDouble(double x1, double y1, double x2, double y2)
        {
            double firstValue = Math.Abs(x1) + Math.Abs(y1);
            double secondValue = Math.Abs(x2) + Math.Abs(y2);

            return firstValue + secondValue;
        }

        static double FindLengthOfSecondDouble(double x1, double y1, double x2, double y2)
        {
            double firstValue = Math.Abs(x1) + Math.Abs(y1);
            double secondValue = Math.Abs(x2) + Math.Abs(y2);

            return firstValue + secondValue;
        }

        static void PrintTheLineInCorrectOrder(double x1, double y1, double x2, double y2)
        {
            double firstValue = Math.Abs(x1) + Math.Abs(y1);
            double secondValue = Math.Abs(x2) + Math.Abs(y2);

            if (firstValue <= secondValue)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
