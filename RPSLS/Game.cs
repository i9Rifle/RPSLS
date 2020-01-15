using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        Player player1;
        Player player2;

        public void RunGame() // master method
        {
            string numberOfPlayers = ChoseNumberOfPlayers();
            SetPlayers(numberOfPlayers);

            Round();

        }
        public string ChoseNumberOfPlayers()
        {
            Console.WriteLine("How many players");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }
        public void SetPlayers(string NumberOfPlayers)
        {
            if(NumberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new CPU();
            }
            else if(NumberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new CPU();
            }
        }
        public void Round()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGestures();
        }

        public void CompareGestures()
        {
            // check tie first
            // then check all p1 wins scenarios
            // if none of those, p2 wins
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Draw!");
            }
            else if (player1.gesture = "Rock" && player2.gesture = "Scissors")
            {
                Console.WriteLine("Player 1 Wins Round!");
            }
            else if (player1.gesture = "Paper" && player2.gesture = "Rock")
            {
                Console.WriteLine("Player 1 Wins Round!");
            }
            else if (player1.gesture = "Scissors" && player2.gesture = "Paper")
            {
                Console.WriteLine("Player 1 Wins Round");
            }
            else if (player1.gesture = "Rock" && player2.gesture = "Lizard")
            {
                Console.WriteLine("Player 1 Wins Round!");
            }
            else if (player1.gesture = "Lizard" && player2.gesture = "Spock")
            {
                Console.WriteLine("Player 1 Wins Round");
            }
            else if (player1.gesture = "Spock" && player2.gesture = "Scissors")
            {
                Console.WriteLine("Player 1 Wins Round");
            }
            else if (player1.gesture = "Scissors" && player2.gesture = "Lizard")
            {
                Console.WriteLine("Player 1 Wins Round!");
            }
            else if (player1.gesture = "Lizard" && player2.gesture = "Paper")
            {
                Console.WriteLine("Player 1 Wins Round!");
            }
            else if (player1.gesture = "Paper" && player2.gesture = "Spock")
            {
                Console.WriteLine("Player 1 Wins Round!");
            }
            else if (player1.gesture = "Spock" && player2.gesture = "Rock")
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else
            {
                Console.WriteLine("Player 2 Wins!");
            }
        }

    }


}
