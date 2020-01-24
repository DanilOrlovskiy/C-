using System;

namespace structure5
{
    public static class ColorPrint
    {
        public static void Print(string stroka,int color)
        {
            switch (color)
            {
                case (1):
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    }
                case (2):
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    }
                case (3):
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    }
            }
        }
      class Program
      {
        static void Main(string[] args)
        {
            string stroka;
            int color;

            Console.WriteLine("Введите Текст");
            stroka = Console.ReadLine();
            Console.WriteLine("Введите номер цвета:\n 1 - красный\n 2 - Синий\n 3 - белый");
            color = int.Parse(Console.ReadLine());

            Print(stroka, color);
        }
      }
    }
}
