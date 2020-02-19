using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate int Calc(int a, int b, int c);


        static void Main(string[] args)
        {

            Calc calc = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };

            int result = calc(4, 5, 8);
            Console.WriteLine(result);
        }
    }
}
