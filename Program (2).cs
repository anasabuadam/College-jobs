using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter n1");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n2");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("before: x = {0}, y = {1}", x, y);

            /// x = 5, y = 10
            int z = x;
            x = y;
            y = x;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("after: x = {0}, y = {1}", y, x);

    





                }
                }
        
    }

