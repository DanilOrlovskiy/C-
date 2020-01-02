using System;

namespace Class7
{
    class Employee
    {
        public string name;
        public string surname;
        public static string dateOfHire;
        public OperateCost operationCost;

        public Employee(string name, string surname, string dateOfHire, OperateCost opCost)
        {
            this.name = name;
            this.surname = surname;
            Employee.dateOfHire = dateOfHire;
            this.operationCost = opCost;

        }

        public static double DiscoverGrade(string dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(dateOfHire)).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.1;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.5;
        }
    }
        abstract class OperateCost
        {
            public double salary;
            public double tax;

            public abstract void ApplyBonus(double bonus, double grade);
            public abstract void ApplyTax();
        }

        class Junior : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (10000 + 2 * bonus) * grade;
            }

            public override void ApplyTax()
            {
                tax = salary * 0.25;
            }
        }

        class Middle : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (25000 + 5 * bonus) * grade;
            }
            public override void ApplyTax()
            {
                tax = salary * 0.25;
            }
        }

        class Senior : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (50000 + 10 * bonus) * grade;
            }
            public override void ApplyTax()
            {
                tax = salary * 0.25;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                OperateCost oc = new Middle();
                Employee emp = new Employee("Данил", "Орловский", "12.12.2019", oc);
                double grade = Employee.DiscoverGrade("09.02.2000");
                Console.WriteLine(" Имя: {0}\n Фамилия: {1}\n Дата приема на работу: {2}\n Должность: {3}\n", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
                oc.ApplyBonus(10000, grade);
                oc.ApplyTax();
                Console.WriteLine("Зарплата: {0}, Налог: {1}", emp.operationCost.salary, emp.operationCost.tax);
                Console.ReadKey();
            }
        }
}
