using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public void StartPlaying()
        {
            int StartPoint = 0;
            int RanDice;
            Console.WriteLine("Game Started! Good Luck ");
            Console.WriteLine("You are at " + StartPoint);
            Random Random = new Random();
            RanDice = Random.Next(1, 7);
            Console.WriteLine("player Role Dice number is:" + " " + RanDice);
        }
    }
}
