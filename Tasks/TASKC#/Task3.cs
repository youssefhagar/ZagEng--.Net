using System;
using System.Collections.Generic;

namespace Task3_ZagEng
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ClassifyNumbers(numbers);
        }

        static void ClassifyNumbers(List<int> numbers)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> primes = new List<int>();

            foreach (int num in numbers)
            {
                if (num%2 == 0)
                    evens.Add(num);

                if (num % 2 != 0)
                    odds.Add(num);

                if (IsPrime(num))
                    primes.Add(num);
            }

            Console.WriteLine($"\n - Even Numbers :");  PrintList(evens);
            Console.WriteLine($"\n - Odd Numbers :");  PrintList(odds);
            Console.WriteLine($"\n - Prime Numbers :");  PrintList(primes);
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void PrintList(List<int> list)
        {
            foreach (int n in list)
                Console.Write(n + " ");
        }
    }
}
