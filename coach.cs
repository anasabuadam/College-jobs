using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp18
{
    public class coach

    {
        public PlayersGamer[] _playersGamers;

        public string GetcoLorOfPlayer()
        {
            string sum = "";
            for (int i = 0; i < _playersGamers.Length; i++)
            {

                sum = sum + _playersGamers[i]._colorofplyer;
            }
            return sum;

        }
        public int NumPlayer()
        {
            int num = 0;
            for (int i = 0; i < _playersGamers.Length; i++)
            {
                num = num + _playersGamers[i]._numplayer;
            }
            return num;
        }
    }
}
      













