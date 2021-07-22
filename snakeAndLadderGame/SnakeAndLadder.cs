using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        int position;
        public SnakeAndLadder()
        {
            this.position = 0;
        }
        public void Play()
        {
            Console.WriteLine("Player is at position :" + this.position);
        }
    }
}
