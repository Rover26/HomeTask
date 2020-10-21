using System;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Для определения ИМТ введите свой вес: ");
            string massa = Console.ReadLine();
            int m = Convert.ToInt32(massa);
            Console.WriteLine("И рост: ");
            string haight = Console.ReadLine();
            var h = Convert.ToInt32(haight);
            int i = m / (h * h);
            Console.WriteLine("Получилось " + i);






        }
    }
}
