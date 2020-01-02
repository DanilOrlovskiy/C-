using System;

namespace ConsoleApp1
{

    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine("\n"+ value);
        }
    }

    class Red : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }
    class Blue : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            print.Print("Первая строка");
            print = new Red();
            print.Print("Вторая строка");
            print = new Blue();
            print.Print("Третья строка");

            Console.ReadKey();
        }
    }
}
