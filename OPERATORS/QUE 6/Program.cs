using System;

namespace QUE_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            int b = a / 100;
            int c = b % 10;
            if(c == 7)
            {
                Console.WriteLine("Seven exists");
            }
            else
            {
                Console.WriteLine("Seven doesn't exists counting from the digit from left");
            }
        }
    }
}
