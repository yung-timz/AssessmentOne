using System;

namespace QUE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a num");
            int number =int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            int add = 0;
            int final = 0;
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            for (int a = 1; a <= number; a++)            
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
