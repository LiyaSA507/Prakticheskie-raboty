using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec, sot, ed, factordec=1, factored=1, factorsot=1;
            for(int i = 100; i<1000;i++)
            {
                sot = i / 100;
                dec = (i - (sot * 100)) / 10;
                ed = (i - (sot * 100 + dec * 10));
                for(int k =1; k<=sot; k++)
                {
                    factorsot *= k;
                }
                for (int j = 1; j <= dec; j++)
                {
                    factordec *= j;
                }
                for (int s = 1; s <= sot; s++)
                {
                    factored *= s;
                }
                if(factordec+factored+factorsot==i)
                {
                    Console.WriteLine(i);
                }
                factorsot = 1;
                factored = 1;
                factordec = 1;
            }
        }
    }
}
