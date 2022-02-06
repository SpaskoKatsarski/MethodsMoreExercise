using System;

namespace T01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            PrintValue(type, input);
        }

        static void PrintValue(string type, string input)
        {
            if (type == "int")
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine(number * 2);
            }
            else if (type == "real")
            {
                double number = Convert.ToDouble(input);
                Console.WriteLine($"{(number * 1.5):f2}");
            }
            else if (type == "string")
            {
                Console.WriteLine($"${input}$");
            }
        }
    }
}
