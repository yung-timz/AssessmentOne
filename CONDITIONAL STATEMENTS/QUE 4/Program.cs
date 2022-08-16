using System;

namespace QUE_4
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
            int c = int.Parse( Console.ReadLine());

            if(a >= b && b >= c)
             {
               Console.WriteLine($" {a}, {b}, {c}");
             }  

            else if(b >= a && a >= c)
             {
                 Console.WriteLine($" {b}, {a}, {c}");
             }

            else if(c >= b && b >= a )
             {
                 Console.WriteLine($" {c}, {b}, {a}");
             }
            
             else if(c >= a && a >= b)
             {
                 Console.WriteLine($"{c}, {a}, {b}");
             }
             else if(b >= c && c >= a)
             {
                 Console.WriteLine($"{b}, {c}, {a}");
             }
             else
             {
                 Console.WriteLine($"{a}, {c}, {b}");
             }
        }
    }
}
