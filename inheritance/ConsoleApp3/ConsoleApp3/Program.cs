using System;

namespace ConsoleApp3
{
    internal class Vehicle
    {
        private double coordinateX, coordinateY;
        private double price, speed, year;

        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year
        {
            get { return year; }
            set { year = value; }
        }


        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }
        public void SpeedMethod(double Speed)
        {
            this.Speed = Speed;
        }
       
    }
    class Plane : Vehicle
    {
        public double Height { get; set; }
        public double NumberOfPassengers { get; set; }
    }
    class Ship : Vehicle
    {
        public double NumberOfPassengers { get; set; }
        public string DestinationPort { get; set; }
    }
    class Car : Vehicle
    {

    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Самолёт\n");
            var plane = new Plane { Year = 2006, Price = 1000000, Height = 1500, NumberOfPassengers = 110, Speed = 350 };
            plane.Coordinate(132, 23);
            Console.WriteLine("Год выпуска: {0}", plane.Year.ToString());
            Console.WriteLine("Стоимость самолёта: {0}", plane.Price.ToString());
            Console.WriteLine("Координаты самолета X: {0},Y: {1}", plane.CoordinateX.ToString(), plane.CoordinateY.ToString());
            Console.WriteLine("Высота полёта: {0}", plane.Height.ToString());
            Console.WriteLine("Число пассажиров: {0}", plane.NumberOfPassengers.ToString());
            Console.WriteLine("Скорость: {0}", plane.Speed.ToString());
            Console.WriteLine("\nМашина\n");
            var car = new Car { Price = 25000, Year = 2015, Speed = 220};
            car.Coordinate(35, 48);
            Console.WriteLine("Стоимость машины: {0}", car.Price.ToString());
            Console.WriteLine("Координаты машины X: {0},Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());
            Console.WriteLine("Год выпуска: {0}", car.Year.ToString());
            Console.WriteLine("Стоимость машины: {0}", car.Price.ToString());
            Console.WriteLine("Скорость: {0}", car.Speed.ToString());
            var ship = new Ship { Price = 1000000, Year = 1999, Speed = 90, DestinationPort = "Порт Одесса" };
            ship.Coordinate(67, 23);
            Console.WriteLine("\nКорабль\n");
            Console.WriteLine("Стоимость корабля: {0}", ship.Price.ToString());
            Console.WriteLine("Координаты корабля X: {0},Y: {1}", ship.CoordinateX.ToString(), ship.CoordinateY.ToString());
            Console.WriteLine("Год выпуска: {0}", ship.Year.ToString());
            Console.WriteLine("Стоимость корабля: {0}", ship.Price.ToString());
            Console.WriteLine("Скорость: {0}", ship.Speed.ToString());
            Console.WriteLine("Порт приписки: {0}", ship.DestinationPort.ToString());
            Console.Read();
        }
    }
}
