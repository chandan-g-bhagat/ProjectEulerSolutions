using System;

namespace CS4_LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (IsPalindrome(product) && product > max)
                    {
                        max = product;
                    }
                }
            }
            Console.WriteLine(max);
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}