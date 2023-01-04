using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Sumulation Program");
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.StartPlaying();
            Console.ReadLine();
        }
    }
}
