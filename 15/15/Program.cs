using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, k, n = 64;
            for (g = 0; g <= n; g++)
            {
                for (k = 0; k <= n / 2; k++)
                {

                    if (2 * g + 4 * k == n)
                    {
                        
                        Console.WriteLine("\n\nГуси - " + g + "\nКролик - "+ k);
                    }
                }
            }

        }
    }
}
