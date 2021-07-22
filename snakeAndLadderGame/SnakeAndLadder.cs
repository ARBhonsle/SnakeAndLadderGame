using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        private int position, diceNumber, playOption,numberDicePlayed;
        int WIN_POSITION = 100;
        public SnakeAndLadder()
        {
            this.position = 0;
            this.numberDicePlayed = 0;
        }
        public void Play()
        {
            Random random = new Random();
            while (this.position < this.WIN_POSITION)
            {
                this.diceNumber = random.Next(0, 6) + 1;
                this.playOption = random.Next(0, 3);
                Console.WriteLine("Player is at position :" + this.position);
                Console.WriteLine("Dice Rolled :" + diceNumber);
                this.numberDicePlayed++;
                switch (playOption)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        if (this.WIN_POSITION >= (this.position + this.diceNumber))
                        {
                            this.position += this.diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("Get correct dice value to Win");
                        }
                        break;
                    case 2:
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
            Console.WriteLine("Player Wins");
            Console.WriteLine("Number of times Dice was rolled to win :" + this.numberDicePlayed);
        }
    }
}
