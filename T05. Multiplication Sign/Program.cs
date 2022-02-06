using System;

namespace T05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            
            PrintResult(firstNum, secondNum, thirdNum);
        }

        static void PrintResult(double numOne, double numTwo, double numThree)
        {
            if (numOne == 0 || numTwo == 0 || numThree == 0)
            {
                Console.WriteLine("zero");
            }
            else if (numOne < 0  && numTwo < 0 && numThree < 0)
            {
                Console.WriteLine("negative");
            }
            else if ((numOne < 0 && numTwo < 0) || (numOne < 0 && numThree < 0) || (numTwo < 0 && numThree < 0))
            {
                Console.WriteLine("positive");
            }
            else if (numOne < 0 || numTwo < 0 || numThree < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
