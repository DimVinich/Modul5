using System;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            ShowArray(array, true);

            Console.ReadKey();
        }

        static void ShowArray(int[] arr, bool needsort = false)  // Выводим массив на экран , если нужно сортирует
        {
            if(needsort)
            {
                arr = SortArray(arr);
            }

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] SortArray(int[] arr)                  //  Сотртирует массив 
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

            return arr;
        }

        static int[] GetArrayFromConsole(int num = 5)      //  Считвает массив с консоли
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
            }
        }       //  Сортитовка двумерного массива

        static void ShowColors(string username = "Jane", params string[] favcolors)  // Выдает цвета через  через перебор forech
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static string ShowColor( string username, int userage)  // Выдает цвета через  через switch
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
            }       // Разбор по цвету с выдачей на экран
            return color;
        }      

    }
}
