﻿using System;

namespace QUE_2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("enter number");
           int a = int.Parse(Console.ReadLine());
           for(int row = 1; row <= 10; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
