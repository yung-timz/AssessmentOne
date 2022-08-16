using System;

namespace QUE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a number");
            int num2 = int.Parse(Console.ReadLine());
            
            switch(operator)
            {
                case '+'; 
                Console.WriteLine(num1 + num2);
                break;

                case '-'; 
                Console.WriteLine(num1 - num2);
                break;

                case '*'; 
                Console.WriteLine(num1 * num2);
                break;

                case '%'; 
                Console.WriteLine(num1 % num2);
                break;

                default: 
                Console.WriteLine("exit");
                break;
            }
            
        }
    }
}
