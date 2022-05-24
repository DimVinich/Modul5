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
            for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i] = ShowColor(anketa.name, anketa.age);
            }


            Console.ReadKey();
        }

        static int[] SortArray(int[] arr)       //      Сотртирует массив и выдаёт его на экран. выдачи пока коммент
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i] < arr[k])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            }

            //  = ну и вывод пока сюда перенесём
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            return arr;
        }

        static int[] GetArrayFromConsole()          //  Считвает массив с консоли
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static string ShowColor( string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
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
