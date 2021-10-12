using System;

namespace CS6_SumSquareDifference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            double sumOfSquare = 0, squareOfSum = 0;
            for (int i = 1; i <= num; i++)
            {
                sumOfSquare += Math.Pow(i, 2);
                squareOfSum += i;
            }
            squareOfSum = Math.Pow(squareOfSum, 2);
            Console.WriteLine($"Difference between the sum square is {squareOfSum - sumOfSquare}");
            Console.ReadKey();
        }
    }
}