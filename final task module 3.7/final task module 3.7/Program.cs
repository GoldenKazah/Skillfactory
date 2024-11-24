namespace final_task_module_3._7
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("What's your name? \t");
            var name = Console.ReadLine();
            Console.Write("What's your age? \t");
            var age = (byte)byte.Parse(Console.ReadLine());
            Console.Write("Enter tour birthdate: \t");
            var bdate = Console.ReadLine();
            Console.WriteLine("User's Data:\n Name {0}\n Age {1}\n Birthdate {2}", name, age, bdate);
        }
    }
}