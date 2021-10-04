namespace CS3_LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 600851475143;
            int largestPrimeFactor = 0;
            int i = 2;

            while (i <= number)
            {
                if (number % i == 0)
                {
                    number = number / i;
                    largestPrimeFactor = i;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(largestPrimeFactor);
        }
    }
}