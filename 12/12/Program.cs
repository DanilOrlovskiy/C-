using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x;
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            x = i * i;
            while (x <= n)
            {
                Console.WriteLine(x);
                i++;
                x = i * i;
            }
        }
    }
}
