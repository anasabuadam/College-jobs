using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
          if(args.Length <2 )
            {
                Console.WriteLine("erorr");
                return;
            }
            Console.WriteLine("good");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{i+1}:{args[i]}");
            }
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            Console.WriteLine($"{a}+{b} = {(a+b)}");
        }
    }
}
