using System;

namespace Анкета
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title ="Анкета";  

            Console.WriteLine("Ваше имя? ");
            string a = Console.ReadLine();

            Console.WriteLine("Ваша фамилия? ");
            string b = Console.ReadLine();

            Console.WriteLine("Ваш возраст? ");
            string c = Console.ReadLine();

            Console.WriteLine("Ваш рост? ");
            string d = Console.ReadLine();

            Console.WriteLine("Ваш вес? ");
            string e = Console.ReadLine();

            Console.WriteLine("Вот что у нас получилось! " + a + " " + b + " " + c + " " + d + " " + e);
            Console.WriteLine("Вот что у нас получилось! " + a +" "+ b + " " + "{0}  {1}  {2}", c, d, e);
            Console.WriteLine($"Вот что у нас получилось! {a}  {b}  {c}  {d}  {e}");
        







        }
    }
}
