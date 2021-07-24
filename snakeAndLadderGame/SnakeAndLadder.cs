using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    class SnakeAndLadder :ISnakeAndLadder
    {
        int diceValue, playOption;
        int[] positionPlayer = new int[2];
        int[] numberDicePlayed=new int[2];
        readonly int WIN_POSITION = 100;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public SnakeAndLadder()
        {
            for(int i = 0; i < 2; i++)
            {
                this.positionPlayer[i] = 0;
                this.numberDicePlayed[i] = 0;
            }
        }
        public void Play()
        {
            Random random = new Random();
            Console.WriteLine("All Start at Position :" + this.positionPlayer[0]);
            while (this.positionPlayer[0] < WIN_POSITION && this.positionPlayer[1] < WIN_POSITION)
            {                
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Player: " + (i + 1));
                    Console.WriteLine("Dice Rolled :" + diceValue);                    
                    this.diceValue = random.Next(0, 6) + 1;
                    this.playOption = random.Next(0, 3);
                    this.numberDicePlayed[i]++;
                    switch (playOption)
                    {
                        case NO_PLAY:
                            Console.WriteLine("No Play");
                            break;
                        case LADDER:
                            Console.WriteLine("Ladder");
                            if (this.WIN_POSITION >= (this.positionPlayer[i] + this.diceValue))
                            {
                                this.positionPlayer[i] += this.diceValue;
                            }
                            else
                            {
                                Console.WriteLine("Get correct dice value to Win");
                            }
                            break;
                        case SNAKE:
                            Console.WriteLine("Snake");
                            if (this.positionPlayer[i] > this.diceValue)
                            {
                                this.positionPlayer[i] -= this.diceValue;
                            }
                            else
                            {
                                this.positionPlayer[i] = 0;
                            }

                            break;
                    }
                    Console.WriteLine("Position :" + this.positionPlayer[i]);
                    if (positionPlayer[1].Equals(WIN_POSITION))
                    {
                        Console.WriteLine("Player 2 Wins"); break;
                    }
                    if (positionPlayer[0].Equals(WIN_POSITION))
                    {
                        Console.WriteLine("Player 1 Wins"); break;
                    }
                    if (playOption == LADDER)
                    {
                        Console.WriteLine("Get another dice roll due to ladder");
                        i--;
                        continue;
                    }                
                }
                Console.WriteLine();
            }
        }
    }
}
