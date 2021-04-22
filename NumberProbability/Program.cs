using System;

namespace NumberProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2 };
            Console.WriteLine("numbers are : ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Possible number pairs are : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                     Console.WriteLine(numbers[i]+","+numbers[j]);
                }
            }
        }
    }
}
