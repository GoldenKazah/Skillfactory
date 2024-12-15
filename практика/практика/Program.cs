namespace практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void ShowColors(params string[] favcolors)
            {
                Console.WriteLine("Ваши любимые цвета:");
                foreach (var color in favcolors)
                {
                    Console.WriteLine(color);
                }
            }
            ShowColors(favcolors[0], favcolors[2]);
        }
    }
}
