using System;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;

            Console.WriteLine("Ведеите имя:");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Введите любимое блюдо № {0}:", i);
                User.Dishes[i] = Console.ReadLine();
            }


            Console.ReadKey();
        }
    }
}
