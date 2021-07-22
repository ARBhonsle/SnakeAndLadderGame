using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        private int position, diceNumber, playOption;
        private int WIN_POSITION=100;
        public SnakeAndLadder()
        {
            this.position = 0;
        }
<<<<<<< HEAD
        public void Play()
        {
            Console.WriteLine("Player is at position :" + this.position);
            Random random = new Random();
=======

        public void Play()
        {
>>>>>>> UC5-exactWin
            while (this.position < this.WIN_POSITION)
            {
                this.diceNumber = random.Next(0, 6) + 1;
                this.playOption = random.Next(0, 3);
<<<<<<< HEAD
                Console.WriteLine("Player is at position :" + this.position);                
=======
                Console.WriteLine("Player is at position :" + this.position);
>>>>>>> UC5-exactWin
                Console.WriteLine("Dice Rolled :" + diceNumber);
                switch (playOption)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
<<<<<<< HEAD
                        this.position += this.diceNumber;
=======
                        if (this.WIN_POSITION >= (this.position + this.diceNumber))
                        {
                            this.position += this.diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("Get correct dice value to Win");
                        }
>>>>>>> UC5-exactWin
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
