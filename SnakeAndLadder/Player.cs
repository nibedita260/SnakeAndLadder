using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Player
    {
        const int No_PLAY = 1, LADDER = 2, SNAKE = 3,MAX_PLAYER_POSITION=100;
        int playerPosition = 0,count=0;
        
        public void play()
        {
            Random random = new Random();
            int rollDie = random.Next(1, 6);
            int options = random.Next(1, 3);
            Console.WriteLine("Afer rolls a die , the number get :" + options);
            while (playerPosition < MAX_PLAYER_POSITION)
            {
                count++;
                do {
                    switch (options)
                    {
                        case LADDER:
                            Console.WriteLine("Ladder");
                            playerPosition += rollDie;
                            break;
                        case SNAKE:
                            Console.WriteLine("Snake");
                            playerPosition -= rollDie;
                            break;
                        case No_PLAY:
                            Console.WriteLine("No PLAY");
                            //playerPosition = 0;
                            break;
                        default:
                            break;
                    }

                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }
                    Console.WriteLine("Player position till reaches the points are:" + playerPosition);
                } while (playerPosition!=100 && options==1);
            }
           
            Console.WriteLine("After rolled a dice ,player position:" + playerPosition);

        }
    }
}
