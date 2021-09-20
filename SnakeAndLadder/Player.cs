using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Player
    {
        int playerPosition=0;
        public void Play()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            Console.WriteLine("Afer rolls a die , the number get :" + number);
        }
    }
}
