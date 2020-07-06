using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string familyname;
           
        
            Console.WriteLine("please enter your name:");
            username = Console.ReadLine();

            Console.WriteLine("please enter your family:");
            familyname = Console.ReadLine();

            Console.WriteLine("{0} {1} nice too meet you:)", username ,familyname);


            int day, month, year;
            Console.WriteLine("enter your birth date");
            Console.WriteLine("day");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("month");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("year");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/{1}/{2}",day, month, year);
        }
    }
}
