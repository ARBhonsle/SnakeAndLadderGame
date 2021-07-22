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
            Random random = new Random();
            Console.WriteLine("All Start at Position :" + this.position);
            while (this.position1[0] < WIN_POSITION && this.position1[1] < WIN_POSITION)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Player: " + (i + 1));
                    Console.WriteLine("Position :" + this.position1[i]);
                    Console.WriteLine("Dice Rolled :" + diceNumber1[i]);                    
                    this.diceNumber1[i] = random.Next(0, 6) + 1;
                    this.playOption1[i] = random.Next(0, 3);
                    this.numberDicePlayed1[i]++;
                    switch (playOption1[i])
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;
                        case 1:
                            Console.WriteLine("Ladder");
                            if (this.WIN_POSITION >= (this.position1[i] + this.diceNumber1[i]))
                            {
                                this.position1[i] += this.diceNumber1[i];
                            }
                            else
                            {
                                Console.WriteLine("Get correct dice value to Win");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            if (this.position1[i] > this.diceNumber1[i])
                            {
                                this.position1[i] -= this.diceNumber1[i];
                            }
                            else
                            {
                                this.position1[i] = 0;
                            }

                            break;
                    }
                    if (position1[1].Equals(WIN_POSITION))
                    {
                        Console.WriteLine("Player 2 Wins"); break;
                    }
                    if (position1[0].Equals(WIN_POSITION))
                    {
                        Console.WriteLine("Player 1 Wins"); break;
                    }
                    if (playOption1[i] == 1)
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
