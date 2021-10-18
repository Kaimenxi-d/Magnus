using System;

namespace ConsoleApp2
{
    class Mains
    {
        static void Main(string[] args)
        {
            Doch1 sm = new Doch1();
            Doch1.PrintUsername();
            Doch2 ms = new Doch2();
            Doch2.Ds();
        }
    }
    class Employee
    {
        public static void PrintUsername()
        {
            Console.Write("Введите своё имя:");
            string ft = Console.ReadLine();
            Console.WriteLine($"Имя пользователя:{ft}");
            Console.ReadKey();
        }
        public static void Ds()
        {
            Console.WriteLine("Лаба Ильяса");
        }

    }
    class Doch1:Employee
    {


    }
    class Doch2:Employee
    {


    }
    class Doch3
    {


    }
}
