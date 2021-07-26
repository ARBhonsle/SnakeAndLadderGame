using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        private int position, diceNumber, playOption;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int WIN_POSITION = 100;
        public SnakeAndLadder()
        {
            this.position = 0;
        }
        public void Play()
        {
            Console.WriteLine("Player is at position :" + this.position);
            Random random = new Random();
            while (this.position < this.WIN_POSITION)
            {
                this.diceNumber = random.Next(0, 6) + 1;
                this.playOption = random.Next(0, 3);
                Console.WriteLine("Player is at position :" + this.position);                
                Console.WriteLine("Dice Rolled :" + diceNumber);
                switch (playOption)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;
                    case LADDER:
                        Console.WriteLine("Ladder");
                        this.position += this.diceNumber;
                        break;
                    case SNAKE:
                        Console.WriteLine("Snake");
                        if (this.position > this.diceNumber)
                        {
                            this.position -= this.diceNumber;
                        }
                        else
                        {
                            this.position = 0;
                        }
                        break;
                }
            }
        }
    }
}
