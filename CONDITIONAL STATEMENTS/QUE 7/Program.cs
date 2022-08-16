using System;

namespace QUE_7
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

            Console.WriteLine("enter a num");
            int e = int.Parse(Console.ReadLine());

            int great = 0;

            if(a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }

             else if(b > a && b > c && b > d && b > e)
             {
                 Console.WriteLine(b);
             }

             else if(c > a && c > b && c > d && c > e )
             {
                 Console.WriteLine(c);
             }

             else if(d > a && d > b && d > c && d > e)
             {
                 Console.WriteLine(d);
             }

             else if(e > a && e > b && e > c && e > d)
             {
                 Console.WriteLine(e);
             }

             else
             {
                 Console.WriteLine("they are the same");
             }
        }
    }
}
