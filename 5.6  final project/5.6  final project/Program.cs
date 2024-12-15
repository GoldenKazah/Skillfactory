namespace _5._6__final_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string, string, int, string[], string[]) User()
            {
                Console.WriteLine("Enter your name");
                string user_name = Console.ReadLine();
                Console.WriteLine("Enter your lastname");
                string user_lastname = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int user_age = Checknumber();
                Console.WriteLine("Do you have a pet? Yes/No");
                string petanswer = Console.ReadLine();
                bool petlogic;
                int petsnumber = 0;
                while (petanswer != "Yes" && petanswer != "yes" && petanswer != "Да" && petanswer != "Да" && petanswer != "No" && petanswer != "no" && petanswer != "Нет" && petanswer != "нет")
                {
                    Console.WriteLine("Wrong answer! Use Yes/No or Да/Нет for answer");
                    petanswer = Console.ReadLine();
                }
                if (petanswer == "Yes" | petanswer == "yes" | petanswer == "Да" | petanswer == "Да")
                    petlogic = true;
                else petlogic = false;
                if (petlogic)
                {
                    Console.WriteLine("Enter number of your pets");
                    petsnumber = Checknumber();

                }
                string[] user_Petsnames = Pet(petsnumber);
                Console.WriteLine("Enter number of your favorite colors");
                int user_favcolors_number = Checknumber();
                string[] user_favcolors = Favcolors(user_favcolors_number);

                string[] Favcolors(int colorsnumber) //метод выдает массив любимых цветов
                {
                    string[] colors = new string[colorsnumber];
                    for (int i = 0; i < colorsnumber; i++)
                    {
                        Console.WriteLine("Enter your {0} favorite color", i + 1);
                        colors[i] = Console.ReadLine();
                    }
                    return colors;
                }

                string[] Pet(int petnumber)  // Метод выдает массив имен питомцев
                {
                    string[] Pet = new string[petnumber];
                    for (int i = 0; i < petnumber; i++)
                    {
                        Console.WriteLine("Enter name of your {0} pet", i + 1);
                        Pet[i] = Console.ReadLine();
                    }
                    return Pet;
                }

                int Checknumber() // Массив проверяет вверно ли введено числовое значение, и не отрицательное ли оно
                {
                    string enternumber = Console.ReadLine();
                    if (int.TryParse(enternumber, out int number))
                    {
                        if (number < 0)
                        {
                            Console.WriteLine("Wrong Number, number must be greater than zero.");
                            return Checknumber();
                        }
                        else return number;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number, USE 1 2 3 4 5 6 7 8 9 0 on ketboard");
                        return Checknumber();
                    }
                }
                return (user_name, user_lastname, user_age, user_Petsnames, user_favcolors);
            }
            void Show_user_data((string, string, int, string[], string[]) User)
            {
                Console.WriteLine();
                Console.WriteLine("User's data");
                Console.WriteLine($"Name: {User.Item1}");
                Console.WriteLine($"Lastname: {User.Item2}");
                Console.WriteLine($"Age: {User.Item3}");
                if (User.Item4.Length ==0)
                    Console.WriteLine("User doesn't have pets");
                else
                {
                    Console.Write($"Pets names: ");
                    for (int i = 0; i < User.Item4.Length; i++)
                    {
                        Console.Write($"{User.Item4[i]}");
                        if (i != User.Item4.Length - 1) Console.Write(", ");
                    }
                }
                
                Console.Write($"Favorite colors: ");
                for (int i = 0; i < User.Item5.Length; i++)
                {
                    Console.Write($"{User.Item5[i]}");
                    if (i != User.Item5.Length - 1) Console.Write(", ");
                }
            }
            Show_user_data(User());
        }
    }
}
