using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class ClassRoom
    {
        public readonly List<Pupil> Pupils = new List<Pupil>();

        public ClassRoom(params Pupil[] pupils)
        {
            Pupils.AddRange(pupils);
        }

        public void GetPupilsRead()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Read();
            }
        }
        public void GetPupilsWrite()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Write();
            }
        }
        public void GetPupilsStudy()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Study();
            }
        }
        public void GetPupilsRelax()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Relax();
            }
        }
    }
    class Pupil
        {
        public string PupilName { get; private set; }
        public Pupil(string name)
        {
            PupilName = name;
        }
        private string NameAndStatus()
        {
            return String.Format("{0} {1}", GetType().Name, PupilName);
        }
        public virtual void Study()
            {
            Console.WriteLine(NameAndStatus());
            }
        public virtual void Read() 
            {
            Console.WriteLine(NameAndStatus());
            }
        public virtual void Write()
            {
            Console.WriteLine(NameAndStatus());
            }
        public virtual void Relax()
            {
            Console.WriteLine(NameAndStatus());
            }
    }
  
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name)
       : base(name)
        { }
        public override void Read()
        {
            Console.WriteLine("{0} - отлично Читает", PupilName);
        }
        public override void Write()
        {
            Console.WriteLine("{0} - отлично Пишет", PupilName);
        }
        public override void Study()
        {
            Console.WriteLine("{0} - отлично Учится", PupilName);
        }
        public override void Relax()
        {
            Console.WriteLine("{0} - отлично Отдыхает", PupilName);
        }
    }
    class GoodPupil : Pupil
    {
        public GoodPupil(string name)
      : base(name)
        { }
        public override void Read()
        {
            Console.WriteLine("{0} - хорошо Читает", PupilName);
        }
        public override void Write()
        {
            Console.WriteLine("{0} - хорошо Пишет", PupilName);
        }
        public override void Study()
        {
            Console.WriteLine("{0} - хорошо Учится", PupilName);
        }
        public override void Relax()
        {
            Console.WriteLine("{0} - хорошо Отдыхает", PupilName);
        }
    }
    class BadPupil : Pupil
    {
        public BadPupil(string name)
     : base(name)
        { }
        public override void Read()
        {
            Console.WriteLine("{0} - плохо Читает", PupilName);
        }
        public override void Write()
        {
            Console.WriteLine("{0} - плохо Пишет", PupilName);
        }
        public override void Study()
        {
            Console.WriteLine("{0} - плохо Учится", PupilName);
        }
        public override void Relax()
        {
            Console.WriteLine("{0} - плохо Отдыхает", PupilName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil First = new GoodPupil("Борис");
            Pupil Second = new ExcelentPupil("Данил");
            Pupil Third = new GoodPupil("Виктор");
            Pupil Forth = new BadPupil("Алексей");

            var firstClassRoom = new ClassRoom(First);
            var secondClassRoom = new ClassRoom(First, Second);
            var thirdClassRoom = new ClassRoom(First, Second, Third);
            var forthClassRoom = new ClassRoom(First, Second, Third, Forth);
            Console.WriteLine("\nЧтение");
            forthClassRoom.GetPupilsRead();
            Console.WriteLine("\nПисьмо");
            forthClassRoom.GetPupilsWrite();
            Console.WriteLine("\nУчеба");
            forthClassRoom.GetPupilsStudy();
            Console.WriteLine("\nОтдых");
            forthClassRoom.GetPupilsRelax();
        }   
    }
}
