using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number between > - 10");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("{0} is zero", num);
            }
            else if (num % 2 == 0) 
            {
                Console.WriteLine("{0} is even", num);
            }
            else
            {
                Console.WriteLine("{0} is ood", num);
            }
            Console.WriteLine("main fucnction end");
        }
    }
}
