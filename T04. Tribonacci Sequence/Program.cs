using System;

namespace T04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintFibonacciSequence(num);
        }

        static void PrintFibonacciSequence(int num)
        {
            int[] fibonacciSequence = new int[num];

            if (num == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
                return;
            }
            else if (num == 3)
            {
                Console.WriteLine("1 1 2");
                return;
            }

            fibonacciSequence[0] = 1;
            fibonacciSequence[1] = 1;
            fibonacciSequence[2] = 2;

            for (int i = 3; i < num; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2] + fibonacciSequence[i - 3];
            }

            Console.WriteLine(string.Join(" ", fibonacciSequence));
        }
    }
}
