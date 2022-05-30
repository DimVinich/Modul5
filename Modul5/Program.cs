using System;

namespace Modul5
{
    class Program
    {
        // ============== Итоговое по модулю 5
        static void Main(string[] args)
        {
            // кортеж, который потом копипастить. ррррр
            //(string Name, string LastName, int Age, string[] NamePet,  string[] FavColor) User;

            var User = InputUser();

            OutputUser(User);

            Console.ReadKey();
        }


//  ===================  метод ввода юзера
        static (string Name, string LastName, int Age, string[] NamePet, string[] FavColor) InputUser()
        {
            (string Name, string LastName, int Age, string[] NamePet, string[] FavColor) User;
            string ls;
            int li;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст");
            do
            {
                ls = Console.ReadLine();
            } while ( ! IsCorrectNumb(ls, out li));
            User.Age = li;
            
            Console.WriteLine("Есть ли у вас питомцы? Да или Нет");
            if (Console.ReadLine() == "Да")
            {
                do
                {
                    Console.WriteLine("Введите кол-во Ваших питомцев");
                    ls = Console.ReadLine();
                } while ( ! IsCorrectNumb(ls, out li));

                User.NamePet = InputPetName(li);
            }
            else
            {
                User.NamePet = Array.Empty<string>();
            }

            do
            {
                Console.WriteLine("Введите кол-во Ваших любимых цветов");
                ls = Console.ReadLine();
            } while (!IsCorrectNumb(ls, out li));
            User.FavColor = InputFavColors(li);

            return User;
        }

        //  ======================= метод вывода кортеджа юзера            
        static void OutputUser((string Name, string LastName, int Age, string[] NamePet, string[] FavColor) User)
        {
            Console.WriteLine("Ваше имя {0} \nВаша фамилия {1} \nВаш возраст {2}", User.Name, User.LastName, User.Age);

            Console.WriteLine("Имена Ваших питомцев ");
            foreach(var larr in User.NamePet)
            {
                Console.WriteLine(larr);
            }

            Console.WriteLine("Ваши любимые цвета");
            foreach (var larr in User.FavColor)
            {
                Console.WriteLine(larr);
            }

        }

        //  ===================== метод ввода любымых цветов
        static string[] InputFavColors(int ColorCount)
        {
            string[] lsa = new string[ColorCount];
            
            for (int i = 0; i < ColorCount; i++)
            {
                Console.WriteLine("Введите Ваш любымый цвет ");
                lsa[i] = Console.ReadLine();
            }
            return lsa;
        }

        //  ====================== метод ввода кличек питомцев, по кол-ву питомцев
        static string[] InputPetName(int PetCount)
        {
            string[] lsa = new string[PetCount];
            for(int i = 0; i < PetCount; i++)
            {
                Console.WriteLine("Введите имя питомца ");
                lsa[i] = Console.ReadLine();
            }
            return lsa;
        }

        //  ======================= метод проверки численных показателей
        static bool IsCorrectNumb(string arg, out int Numb)
        {
            if (int.TryParse(arg, out int li))
            {
                if (li > 0 )
                {
                    Numb = li;
                    return true;
                }
            }

            Console.WriteLine("Введённое значение не является целым положительными числом!");
            Numb = -1;
            return false;
        }

    }
}
