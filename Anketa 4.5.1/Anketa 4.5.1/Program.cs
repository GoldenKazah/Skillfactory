namespace Anketa_4._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           (string name, string lastname, string login, int loginlength, bool petown,int age, string[] favoritecolors) User;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите своё имя");
                User.name = Console.ReadLine();
                Console.WriteLine("Введите свою фамилию");
                User.lastname = Console.ReadLine();
                string Logincorrect()
                {
                    Console.WriteLine("Введите логин");
                    string login = Console.ReadLine();
                    if (login.Length > 8)
                    {
                        return login;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверный логин, логин должен быть больше 8 символов");
                        Logincorrect();
                        return login;
                    }
                }
                User.login = Logincorrect();
                User.loginlength = User.login.Length;
                Console.WriteLine("Есть ли у вас животные");
                string pet = Console.ReadLine();
                if (pet == "Да")
                {
                    User.petown = true;
                }
                else
                { User.petown = false; }
                Console.WriteLine("Введите свой возраст");
                User.age = int.Parse(Console.ReadLine());
                User.favoritecolors = new string[3];
                Console.WriteLine("Введите три своих любимых цвета");
                for (int i = 0; i < User.favoritecolors.Length; i++)
                {
                    User.favoritecolors[i] = Console.ReadLine();
                }
            }
        }
    }
}
