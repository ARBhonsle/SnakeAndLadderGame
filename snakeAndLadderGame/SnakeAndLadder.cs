using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        private int position, diceNumber;
        public SnakeAndLadder()
        {
            this.position = 0;
        }

        public void Play()
        {
            Console.WriteLine("Player is at position :" + this.position);
            Random random = new Random();
            this.diceNumber = random.Next(0, 6) + 1;
            Console.WriteLine("Dice Rolled :" + diceNumber);
        }
    }
}
