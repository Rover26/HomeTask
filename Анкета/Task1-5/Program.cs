using System;

namespace Task1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите свою фимилию: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите свой город: ");
            string c = Console.ReadLine();
                string d = "Имя: " + a + " " + "Фамилия: " + b + " " + "Город: " + c;
            Console.SetCursorPosition((Console.WindowWidth - d.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(d);

        }
    }
}
