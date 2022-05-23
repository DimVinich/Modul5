using System;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            var favcolor = new string[3];
            for(int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i] = ShowColor(anketa.name);
            }

            Console.ReadKey();
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            int temp;

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int k = 0; k < result.Length; k++)
                {
                    if (result[i] < result[k])
                    {
                        temp = result[i];
                        result[i] = result[k];
                        result[k] = temp;
                    }
                }
            }

            foreach (int item in result)
            {
                Console.Write(item + " ");
            }


            return result;
        }

        static string ShowColor( string username)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }


    }
}
