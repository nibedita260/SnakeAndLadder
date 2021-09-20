using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //create object of player1 and player2 to declare which player win!!
            int player1=player.Play(0);
            int player2 = player.Play(0);
                if (player1.CompareTo(player2) == 0)
                {
                    Console.WriteLine("Both Players at same position " + player1 + ",Its a Tie ");
                }
                if (player1.CompareTo(player2) > 0)
                {
                    Console.WriteLine("Player1 wins at position " + player1);
                }
                if (player1.CompareTo(player2) < 0)
                {
                    Console.WriteLine("Player2 wins at position " + player2);
                }
        }
    }
}
