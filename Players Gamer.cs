using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    abstract public class PlayersGamer
    {
        public string _name;
        public int _numplayer;
        public string _colorofplyer;
        public abstract bool IsThisMyFavoritePlayer();


        public override string ToString()
        {
            return ($"{_name} number of player{_numplayer} color of plyer{_colorofplyer}");
        }
    }


    }

