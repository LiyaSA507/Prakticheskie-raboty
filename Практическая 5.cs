using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int delit = 1, chisl;
            Console.WriteLine("Введите номер цифры последовательности:");
            int k = Convert.ToInt32(Console.ReadLine());
            if(k<=9)
            {
                Console.WriteLine(k + "цифра в последовательности:");
                Console.WriteLine(k);
            }
            else
            {
                if(k%2==0)
                {
                    Console.WriteLine(k + "цифра в последовательности:");
                    Console.WriteLine(k/10);
                }
                else
                {
                    for(int i = 10;k>i;i*=10)
                    {
                        delit = i;
                    }
                    for(int i = delit;k>10;i/=10)
                    {
                        chisl = k / i;
                        k = k - (chisl * i);
                    }
                    Console.WriteLine(k + "цифра в последовательности:");
                    Console.WriteLine(k);
                }
            }
        }
    }
}
