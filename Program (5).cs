using System;
using System.Globalization;
using System.Transactions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("enter command (+,-,*,/");
            string command = Console.ReadLine();
            for(int i =1;i<=10;i++)
            { 
                for(int j =1;j<=10;j++)
                {
            if(command == "+")
            {
                        Console.WriteLine(i + "+" + j + "=" + (i + j));

            }

               }
                }
            }
        }
    }






