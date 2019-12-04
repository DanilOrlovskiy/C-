using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Среднее арифметическое этих чисел " + ((a+b+c+d+e)/5));
                     
        }
    }
}
