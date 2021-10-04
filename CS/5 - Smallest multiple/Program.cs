namespace CS5_SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int i = 1;
            while (i < n)
            {
                if (n % i == 0)
                {
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(i * n);
        }
    }
}