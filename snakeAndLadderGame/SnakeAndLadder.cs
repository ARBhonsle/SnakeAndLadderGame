using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        private int position, diceNumber, playOption;
        int WIN_POSITION = 100;
        public SnakeAndLadder()
        {
            this.position = 0;
        }
        public void ShowPosition()
        {
            Console.WriteLine("Player is at position :" + this.position);
        }
        public void DiceValue()
        {
            Random random = new Random();
            this.diceNumber = random.Next(0, 6) + 1;
            Console.WriteLine("Dice Rolled :" + diceNumber);   
        }
        public void PlayOption()
        {
            Random random = new Random();
            this.playOption = random.Next(0, 3);
            switch (playOption)
            {
                case 0: Console.WriteLine("No Play");
                    break;
                case 1: Console.WriteLine("Ladder");
                    this.position += this.diceNumber;
                    break;
                case 2: Console.WriteLine("Snake");
                    this.position -= this.diceNumber;
                    break;
            }
        }
        public void Play()
        {
            while (this.position < this.WIN_POSITION)
            {
                Console.WriteLine("Player is at position :" + this.position);
                Random random = new Random();
                this.diceNumber = random.Next(0, 6) + 1;
                this.playOption = random.Next(0, 3);
                Console.WriteLine("Dice Rolled :" + diceNumber);
                switch (playOption)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        this.position += this.diceNumber;
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
        }
    }
}
