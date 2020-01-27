using System;

namespace structure5
{
    public enum Colors
    {
        Yellow,
        Blue,
        Green
    };

    public static class ColorPrint
    {
        public static void Print(string stroka, int color)
        {
            Colors yColor = Colors.Yellow;
            Colors bColor = Colors.Blue;
            Colors gColor = Colors.Green;
            int yColorIndex = (int)yColor;
            int bColorIndex = (int)bColor;
            int gColorIndex = (int)gColor;

            if (color == yColorIndex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(stroka);
                Console.Clear();
            }
            else if(color == bColorIndex)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(stroka);
                Console.Clear();
            }
            else if (color == gColorIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(stroka);
                Console.Clear();
            }
        }
    }
   class Program 
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Текст");
            string stroka = Console.ReadLine();
            Console.WriteLine("0 — желтый 1 — синий 2 — зеленый ");
            int color = int.Parse(Console.ReadLine());
            ColorPrint.Print(stroka, color);
        }
   }
}
