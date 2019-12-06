using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);
            int d = rnd.Next(0, 100);
            int e = rnd.Next(0, 100);

            Console.WriteLine("Число 1:  " + a);
            Console.WriteLine("Число 2:  " + b);
            Console.WriteLine("Число 3:  " + c);
            Console.WriteLine("Число 4:  " + d);
            Console.WriteLine("Число 5:  " + e);

            Console.WriteLine("\nСреднее арифметическое этих чисел " + ((a + b + c + d + e) / 5));

        }
    }
}
