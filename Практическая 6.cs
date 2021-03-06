﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] mass = new int[n, m];
            Console.WriteLine("Заполненый массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = rnd.Next(-100, 100);
                    Console.Write(mass[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите координаты начала вектора от 0 до "+(n-1));
            int line = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());
            int symm = 1;
            if((line<n)&&(column<m))
            {
                for (int i = line; i < n; i++) //вектор-произведение соответствующих строк
                {
                    symm *= mass[i, column];
                }
                Console.WriteLine("Произведение строк " + symm);
                symm = 0;

                for (int i = column; i < m; i++) //вектор-среднее арифметическое столбцов
                {
                    symm += mass[line, i];
                }
                symm /= m;
                Console.WriteLine("Среднее арифметическое столбцов " + symm);
                symm = 0;

                int[] mono = new int[n - line];
                int key = 0;
                for (int i = line; i < n; i++) //вектор-разность наибольшего и наименьшего
                {
                    mono[key] = mass[i, column];
                    key++;
                }
                Array.Sort(mono);
                symm = mono[key] - mono[0];
                Console.WriteLine("Среднее арифметическое столбцов " + symm);
                symm = 0;

                for (int i = line; i < n; i++) //вектор-отрицательные элементы
                {
                    if (mass[i, column]<0)
                    {
                        Console.WriteLine(mass[i, column]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите правильные координаты!");
            }

        }
    }
}
