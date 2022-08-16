using System;

namespace QUE_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a num");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a num");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a num");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a num");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number in full");
            int number = int.Parse(Console.ReadLine());

            int add = a + b + c + d;
            Console.WriteLine($"the addition of the numbers is {add}");

            Console.WriteLine($"{d}{c}{b}{a}");
            Console.WriteLine($"{d}{a}{b}{c}");
            Console.WriteLine($"{a}{c}{b}{d}");
        }
    }
}
