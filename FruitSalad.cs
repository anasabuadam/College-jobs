using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp17
{
   public class FruitSalad
    {
        public Fruit[] _fruits;
        public int GetTotalCalories()
        {
            int sum = 0;
            for (int i = 0; i < _fruits.Length; i++)
            {
                
                sum = sum + _fruits[i]._calories;
            }
            return sum;
        }
        public bool ContainsMyFavoriteFruit()
        {
            for (int i = 0; i < _fruits.Length; i++)
            {
              if( _fruits[i].IsThisMyFavorite()==true)
                {
                    return true;
                }
              
            }
            return false;
        }

        public override string ToString()
        {
     
            for (int i = 0; i < _fruits.Length; i++)
            {
                Console.WriteLine(_fruits[i].ToString());         
            }
            return "";
            
        }
    }
}
