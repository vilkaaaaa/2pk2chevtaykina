﻿namespace pz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 30; i <= 150; i+= 15)
                Console.WriteLine(i);
            Console.WriteLine("задание 2");
            char s = 'н';
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s);
                s++;

            }
                Console.WriteLine("задание 3");
            for (int m = 0; m < 10; m++)
            {
                for(int n = 0; n<6; n++)
                {
                    Console.WriteLine('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine("задание 4");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 18 == 0) Console.WriteLine($"{i}");
            }
            Console.WriteLine("задание 5");
            for (int i = 0, j = 35; ; i++, j--)
            {
                Console.WriteLine($"{i}, {j}");
                if ((i - j) == 3) break;
            }


        }
    }
}