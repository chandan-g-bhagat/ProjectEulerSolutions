namespace CS2_EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = 1;
            int b = 2;
            int c = 0;
            while (c <= n)
            {
                c = a + b;
                a = b;
                b = c;
                if (c % 2 == 0)
                {
                    sum += c;
                }
            }
            Console.WriteLine(sum);
        }
    }
}