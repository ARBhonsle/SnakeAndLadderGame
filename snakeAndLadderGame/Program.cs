using System;

namespace snakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            ISnakeAndLadder play = new SnakeAndLadder();
            //player.ShowPosition();
            //player.DiceValue();
            //player.PlayOption();
            //player.Play();
            //player.PlayExact();
            //player.ShowNumberDicePlayed();
            play.TwoPlayerGame();
        }
    }
}
