using System;

namespace CS7_10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10001;
            int count = 0;
            int i = 2;
            while (count < n)
            {
                if (IsPrime(i))
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine(i - 1);
        }

        static bool IsPrime(int n)
        {
            if (n == 1 || n == 2)
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