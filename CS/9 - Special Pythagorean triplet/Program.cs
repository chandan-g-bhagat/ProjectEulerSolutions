using System;

namespace CS9_Special_Pythagorean_Triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1000;
            int a, b, c;
            for (a = 1; a < sum; a++)
            {
                for (b = a; b < sum; b++)
                {
                    c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
                        Console.WriteLine("a * b * c = {0}", a * b * c);
                        return;
                    }
                }
            }
        }
    }
}