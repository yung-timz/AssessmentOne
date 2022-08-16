using System;

namespace QUE_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a num");
            int score = int.Parse(Console.ReadLine());
            if(score <= 3 && score >= 1)
            {
                int a =score*10;
                Console.WriteLine(a);
            }
            else if(score <= 6 &&  score >= 4)
            {
                int b =score*100;
                Console.WriteLine(b);
            }
            else if(score <= 9 && score >= 7)
            {
                int c =score*1000;
                Console.WriteLine(c);
            }
            else if(score <= 0 || score >= 9)
            {
                Console.WriteLine("there is an error");
            }
            Console.WriteLine(score);
        }
    }
}
