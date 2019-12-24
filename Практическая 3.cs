using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double symm=1;
            for(int i = 2; i<(Math.PI*Math.PI)/6; i++)
            {
                symm += 1 / Math.Pow(i, 2);
            }
            Console.WriteLine(symm);
        }
    }
}
