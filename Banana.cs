using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    public class Banana : Fruit
    {

        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;


        public override bool IsThisMyFavorite()
        {
            return false;

        }

        public override string ToString()
        {
            return base.ToString() + $"banana has black spots? {_hasBlackSpots} isGreen {_isGreen} size: {_size}";
        }
    }
}
