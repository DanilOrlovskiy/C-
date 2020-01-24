using System;
using System.Linq;
 
namespace SampleConsole
{
  static class Program
  {
    struct Train
    {
      public string Destination;
      public int TrainNumber;
      public string DepartureTime;
    };
 
    static Train GetNewTrainFromKeyboard()
    {
      var destination = ReadConsole("\nВведите пункт назначения");
      var departureTime = ReadConsole("Введите дату отправления");
      var trainNumber = ReadConsole("Введите номер поезда");
 
      return new Train
      {
        Destination = destination,
        DepartureTime = departureTime,
        TrainNumber = int.Parse(trainNumber)
      };
    }
 
    static void PrintTrains(Train[] trains)
    {
      Console.WriteLine("\nВ парке сейчас находятся: ");
      foreach (var trn in trains)
        PrintTrain(trn);
    }
 
    static void PrintTrain(Train trn)
    {
      Console.WriteLine("Номер поезда:{0}\n Пункт назначения:{1}\n Время прибытия{2}", trn.TrainNumber, trn.Destination, trn.DepartureTime);
    }
 
    static string ReadConsole(string message)
    {
      Console.Write("{0}: \n", message);
      return Console.ReadLine();
    }
        static void Main()
        {
            int menu;
            const int count = 8;
            var trains = new Train[count];
            for (var i = 0; i < count; i++)
            {
                trains[i] = GetNewTrainFromKeyboard();
            }
            var sortedPark = trains.OrderBy(t => t.TrainNumber).ToArray();
            PrintTrains(sortedPark);
            do
            {
                Console.Write("\nВведите номер поезда: ");
                var num = int.Parse(Console.ReadLine());
                var trn = trains.Where(t => t.TrainNumber == num);
                if (trn.Count() == 0)
                {
                    Console.WriteLine("\n\nТакого поезда нет\n Если хотите еще раз проверить поезд по номеру нажмите 1");
                    menu = int.Parse(Console.ReadLine());
                }
                else
                {
                    PrintTrain(trn.Single());
                    menu = 0;
                }
            } while (menu == 1);
        }
    }
}
