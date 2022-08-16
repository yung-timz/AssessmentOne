using System;

namespace QUE_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num =int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            int add = 0;
            int final = 0;
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            for (int i = 1; i <= num; i++)            
            {               
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                add += b;
                final = add + 1;
                
            }
            Console.WriteLine($"The add is {final}");
        }
    }
}
