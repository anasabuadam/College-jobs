using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
 
   abstract public class Fruit

    {
        public  string  _name;
        public int _calories;

        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return ($"{_name} calories:{_calories}");
        }
        
    }
}
