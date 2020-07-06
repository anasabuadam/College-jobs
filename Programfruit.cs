using System;
using System.Runtime.InteropServices;

namespace ConsoleApp17
{
    class Program
    {
        static void AppleColor(Apple apple)
        {
            Console.WriteLine(apple._color);
        }
        static void BananaSize(Banana banana)
        {
            Console.WriteLine(banana._size);
        }
        static void TotalCalories(FruitSalad fruitSalad)
        {
            Console.WriteLine(fruitSalad.GetTotalCalories());

        }
        static void MyFavoriteFruit(FruitSalad fruitSalad)
        {
            Console.WriteLine(fruitSalad.ContainsMyFavoriteFruit());

        }
        static FruitSalad FruitSalad(Fruit[] fruits)
        {
            FruitSalad salad = new FruitSalad
            {
                _fruits = fruits
            };
            return salad;
        
        }
        static void Main(string[] args)
        {
            Banana banana = new Banana
            {
                _name="banana2",
                _calories=200,
                _hasBlackSpots = true,
                _size= 6,
                _isGreen = false,


            };
            Apple apple = new Apple
            {
                _name = "apple",
                _calories= 400,
                _color = "black",
                _pinkLady= true,

            };

            Apple apple1 = new Apple
            {
                _name = "apple1",
                _calories = 300,
                _color = "green",
                _pinkLady = false,

            };

            Fruit[] fruits = { banana, apple, apple1 };
            FruitSalad salad = new FruitSalad
            {
                _fruits = fruits
            };

            AppleColor(apple);

            BananaSize(banana);

            TotalCalories(salad);
           MyFavoriteFruit(salad);
            Console.WriteLine( FruitSalad(fruits));

        }
    }
}

            
