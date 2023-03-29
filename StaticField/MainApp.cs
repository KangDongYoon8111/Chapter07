using System;

namespace StaticField
{
    class Global
    {
        public static int Count = 0;
    }

    class Global2
    {
        public int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
            Global2 a = new Global2();
            a.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }

        public static void Main()
        {

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
