using System;

namespace Class6
{

    public class Converter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }
    }

    public class Program
    {
        private static void ConvertTo(Converter сonverter)
        {
            Console.WriteLine("\nВыберите действие:\n 1 - Конвертировать из USD\n 2 - Конвертировать из EUR\n 3 - Конвертировать из RUB\n");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(сonverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(сonverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(сonverter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(Converter сonverter)
        {
            Console.WriteLine("\nВыберите действие:\n 1 - Конвертировать в USD\n 2 - Конвертировать в EUR\n 3 - Конвертировать в RUB\n");
            var option = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(сonverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(сonverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(сonverter.ConvertToRub(input));
                    break;
            }
        }

        public static void Main(string[] args)
        {
            var converter = new Converter(23.7, 26.21, 0.37);

            Console.WriteLine("Выберите действие:\n\n 1 - Конвертировать в гривну \n 2 - Конвертировать гривну");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }
        }  
    }

}
