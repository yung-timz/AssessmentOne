using System;

namespace QUE_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());
            bool num2 = false;
            if( 5 % num1  == 0 && 7 % num1 == 0)
            {
                num2 = true;
                Console.WriteLine(num2);
            }

            else
            {
                num2 = false;
                Console.WriteLine(num2);
            }
 
        }
    }     
}
            

