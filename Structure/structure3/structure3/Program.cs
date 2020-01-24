using System;

namespace structure3
{
    class MyClass
    {
        public string change;
    }   
    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change="Изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {
            MyClass mClass = new MyClass();
            MyStruct mStruct = new MyStruct();
            
            mClass.change = "Не изменено";
            mStruct.change = "Не изменено";
            ClassTaker(mClass);
            StructTaker(mStruct);
            Console.WriteLine(mClass.change);
            Console.WriteLine(mStruct.change);

            //Я так понимаю ,что при создании новой структуры ,она при присваивании имеет свойство копировать сама себя. 
            //А класс создаёт абсолютно новый объект ,с новыми значениями.
        }
    }
}
