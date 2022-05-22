using System;

namespace CS_10_Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (isPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static bool isPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}