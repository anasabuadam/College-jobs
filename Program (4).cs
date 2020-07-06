using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "anas";
            int  pass = 1245;
            Console.WriteLine("enter your name");
            string username = Console.ReadLine();
            Console.WriteLine("enter your pass");
            int pass1 = int.Parse(Console.ReadLine());
            if (name == "anas" && pass == 1245 )
            {
                Console.WriteLine("good job");
            }
            else
            {
                Console.WriteLine("false");
            }
           
        }
    }
}
