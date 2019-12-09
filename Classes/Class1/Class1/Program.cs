using System;

namespace Program1
{
    class Adress
    {
        string index;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        private string country;
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        string city;
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        string street;
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        string house;
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        string apartment;
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
    }
        class Program
        {
            static void Main()
            {

            Adress program = new Adress();

            program.Index = "49128";
            Console.WriteLine(program.Index);
            program.Country = "Украина";
            Console.WriteLine(program.Country);
            program.City = "Днепр";
            Console.WriteLine(program.City);
            program.Street = "Красный камень";
            Console.WriteLine(program.Street);
            program.House = "3";
            Console.WriteLine(program.House);
            program.Apartment = "80";
            Console.WriteLine(program.Apartment);

            }
        }
}