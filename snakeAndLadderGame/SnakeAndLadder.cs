using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        private int position, diceNumber, playOption,numberDicePlayed;
        int[] position1 = new int[2];
        int[] diceNumber1 = new int[2];
        int[] playOption1 = new int[2];
        int[] numberDicePlayed1 = new int[2];
        int WIN_POSITION = 100;
        public SnakeAndLadder()
        {
            this.position = 0;
            this.position1[0] = 0;
            this.position1[1] = 0;
            this.numberDicePlayed = 0;
            this.numberDicePlayed1[0] = 0;
            this.numberDicePlayed1[1] = 0;
        }

        public void Play()
        {
            Console.WriteLine("Player is at position :" + this.position);
        }
        
    }
}
