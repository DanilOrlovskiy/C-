using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите ставку");
            int rate = Convert.ToInt32(Console.ReadLine());
            int value;
            int yon = 1;
            Console.WriteLine("Хотите ли вы сыграть? Если да - нажмите 1, если нет то нажмите 0");
            yon = Convert.ToInt32(Console.ReadLine());
            while (yon == 1)
            {
                value = rnd.Next(1, 12);
                if (value > 0 && value < 6)
                {
                    Console.WriteLine("Вам выпало значение:" + value);
                    rate = 0;
                    Console.WriteLine("Вы проиграли, Ваша ставка: " + rate);
                    break;

                }
                else if (value > 5 && value < 9)
                {
                    Console.WriteLine("Вам выпало значение:" + value);
                    Console.WriteLine("Вы получаете свою ставку обратно, Ваша ставка: " + rate);
                    Console.WriteLine("Хотите ли вы продолжить? Если да - нажмите 1, если нет то нажмите 0");
                    yon = Convert.ToInt32(Console.ReadLine());

                }
                else if (value > 8 && value < 12)
                {
                    Console.WriteLine("Вам выпало значение:" + value);
                    rate *= 2;
                    Console.WriteLine("Вы получаете двойную ставку, Ваша ставка: " + rate);
                    Console.WriteLine("Хотите ли вы продолжить? Если да - нажмите 1, если нет то нажмите 0");
                    yon = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Вам выпало значение:" + value);
                    rate *= 10;
                    Console.WriteLine("Вы получаете десятиричную ставку, Ваша ставка: " + rate);
                    Console.WriteLine("Хотите ли вы продолжить? Если да - нажмите 1, если нет то нажмите 0");
                    yon = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Конец игры, Ваша ставка: " + rate);
        }
    }
}
