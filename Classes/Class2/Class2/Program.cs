using System;

namespace Class2
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 + side2;
        }
        public double PerimeterCalculator()
        {
            return 2*(side1 + side2);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Rectangle(25, 66);
            Console.WriteLine("Area: {0}, Perimeter: {1}", program.Area, program.Perimeter);
        }
    }
}
