using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int val = Convert.ToInt32(Console.ReadLine());
            int c;
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("{0} * {1} = {2}\n", val, i, val * i);
            }
        }
    }
}
