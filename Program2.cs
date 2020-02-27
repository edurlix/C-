using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("como te llamas? ");
            name = Console.ReadLine();

            Console.Write("cuantos años tienes? ");
            age = int.Parse(Console.ReadLine());

            Console.Write($"su nombre es {name} y tienes {age} años");

            Console.ReadKey();
        }
    }
}