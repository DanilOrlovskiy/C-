using System;

namespace _1
{
    static class Calculator
    {
        public static int firstNum { get; set; }
        public static int secondNum { get; set; }
        public static int GetSum()
        {

            return firstNum + secondNum;
        }
        public static int GetSub()
        {
            return firstNum - secondNum;
        }
        public static int GetMult()
        {
            return firstNum * secondNum;
        }
        public static int GetDiv()
        {
            return firstNum / secondNum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            int a, b;
            Console.WriteLine("Введите два числа");
            Calculator.firstNum = int.Parse(Console.ReadLine());
            Calculator.secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Выбор:\n 1 - прибавить\n 2 - отнять\n 3 - умножить\n 4 - разделить");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("\nРезультат: {0}",Calculator.GetSum());
                    break;
                case 2:
                    Console.WriteLine("\nРезультат: {0}", Calculator.GetSub());
                    break;
                case 3:
                    Console.WriteLine("\nРезультат: {0}", Calculator.GetMult());
                    break;
                case 4:
                    Console.WriteLine("\nРезультат: {0}", Calculator.GetDiv());
                    break;
            }

        }
    }
}
