using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double symm = 0, znamenatel = 1;
            while(symm < 0.7)
            {
                symm += 1 / (znamenatel * (znamenatel + 2));
                znamenatel++;
            }
            Console.WriteLine(symm);
        }
    }
}
