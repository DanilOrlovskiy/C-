using System;

namespace ConsoleApp2
{
    class Program
    {
        delegate double Calc(double a, double b);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите действие:\n + - прибавить\n - - отнять\n * - умножить\n / - делить");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "+":
                    Calc Add = (a, b) => a + b;
                    Console.WriteLine(Add(a, b));
                    break;
                case "-":
                    Calc Sub = (a, b) => a - b;
                    Console.WriteLine(Sub(a, b));
                    break;
                case "*":
                    Calc Mul = (a, b) => a * b;
                    Console.WriteLine(Mul(a, b));
                    break;
                case "/":
                    Calc Div = (a, b) => b == 0 ? 0 : a / b;
                    Console.WriteLine(Div(a, b));
                    break;
            }
        }
    }
}
