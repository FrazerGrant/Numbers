using System;

namespace _100_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int max = 100;
            int divisable = 3;
            for (int value = max; value >= 1; value-- )
            {
                if (value % divisable == 0)
                {
                    Console.WriteLine(value);
                    count++;
                }
            }
            Console.WriteLine("Number of times {0} is divisable by {1} is {2}", max, divisable, count);
         Console.ReadKey();
        }
    }
}
