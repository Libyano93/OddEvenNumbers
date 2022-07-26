using System;
using System.Linq;
using System.Collections.Generic;

namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNum("Numbers :", numbers);
            PrintNum("Even No :", numbers.Where(x => isEven(x)));
            PrintNum("Odd No :", numbers.Where(x => isOdd(x)));

            Console.ReadKey();
        }

        static void PrintNum(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine(
                );
            Console.Write($"{title}: [");
            foreach (var n in numbers)
            {
                Console.Write($" {n}]");
            }
            Console.Write($" ]");

            Console.WriteLine();
        }

        static bool isEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isOdd(int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
