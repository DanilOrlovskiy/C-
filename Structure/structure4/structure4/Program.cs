using System;

namespace structure4
{
  
    class Program
    {
        struct Calculation
        {
            public int birthDay;
            public int birthMonth;
            public void Calc()
            {
                DateTime date2 = DateTime.Now;
                int year = date2.Year;
                DateTime date1 = new DateTime(year, birthMonth, birthDay);
               
                TimeSpan diff = date2.Subtract(date1);
                Console.WriteLine("{0} день до вашего Дня Рождения", (diff.Days*-1));

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу дату родения в формате 'D M ' через Enter");

            int birthDay = Convert.ToInt32(Console.ReadLine());
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Calculation calc;
            calc.birthDay = birthDay;
            calc.birthMonth = birthMonth;
            calc.Calc();
        }
    }
}
