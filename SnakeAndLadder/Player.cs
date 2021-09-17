using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Player
    {
        const int No_PLAY = 1, LADDER = 2, SNAKE = 3;
        int playerPosition = 0;
        
        public void play()
        {
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            int options = random.Next(1, 3);
            Console.WriteLine("Afer rolls a die , the number get :" + options);
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
                    playerPosition = 0;
                    break;
                default:
                    break;
            }
            Console.WriteLine("After rolled a dice ,player position:" + playerPosition);

        }
    }
}
