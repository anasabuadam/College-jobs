using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    public class Apple : Fruit
    {
        public string _color;
        public bool _pinkLady;

        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() +$" color:{_color} pink lady?{_pinkLady}";

        }
    }
}
