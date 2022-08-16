using System;

namespace QUE_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int a = 1; a <= num; a++)
            {
                if (a % 3 == 0 && a % 7 == 0)
                {
                    continue;
                }            
                Console.Write(a + " ");   
            }

        }
    }
}
