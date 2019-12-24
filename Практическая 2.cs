using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double symm = 1 / x;
            for(int i = 1; i<=n; i++)
            {
                symm += 1 / (x + i);
            }
            Console.WriteLine("Сумма равна = " + symm);
        }
    }
}
