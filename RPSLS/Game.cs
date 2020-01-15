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


        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("Classic Rock, Paper, Scissors with a twist!");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Play single player (human  vs CPU) or multiplayer (human vs human)");
            Console.WriteLine("User can enter their own custom names");
            Console.WriteLine("Each match will be a 'best of three' series");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Rules: What Beats What?");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporzes Rock");
            Console.WriteLine("-----------------------------");
        }
        public void RunGame() // master method
        {
            WelcomeMessage();
            string numberOfPlayers = ChoseNumberOfPlayers();
            SetPlayers(numberOfPlayers);

            while (player1.score < 2 && player2.score < 2)
            {
                Round();
            }
            if (player1.score == 2)
            {
                Console.WriteLine("Player 1 Wins Game!");
                Console.ReadLine();
            }
            if (player2.score == 2)
            {
                Console.WriteLine("Player 2 Wins Game!");
                Console.ReadLine();
            }
        }
        public string ChoseNumberOfPlayers()
        {
            Console.WriteLine("How many players");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }
        public void SetPlayers(string NumberOfPlayers)
        {
            //In case of invalid number of players input
            bool isValid = false;
            while(isValid == false)
            {
                if (NumberOfPlayers == "1")
                {
                    player1 = new Human();
                    player2 = new CPU();
                    isValid = true;
                }
                else if (NumberOfPlayers == "2")
                {
                    player1 = new Human();
                    player2 = new Human();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Not valid Input try again!");
                    NumberOfPlayers = ChoseNumberOfPlayers();
                }
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
                Console.WriteLine("Draw! Play again!");
            }
            else if (player1.gesture == "Rock" && player2.gesture == "Scissors")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else if (player1.gesture == "Paper" && player2.gesture == "Rock")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else if (player1.gesture == "Scissors" && player2.gesture == "Paper")
            {
                Console.WriteLine("Player 1 Wins Round");
                player1.score++;
            }
            else if (player1.gesture == "Rock" && player2.gesture == "Lizard")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else if (player1.gesture == "Lizard" && player2.gesture == "Spock")
            {
                Console.WriteLine("Player 1 Wins Round");
                player1.score++;
            }
            else if (player1.gesture == "Spock" && player2.gesture == "Scissors")
            {
                Console.WriteLine("Player 1 Wins Round");
                player1.score++;
            }
            else if (player1.gesture == "Scissors" && player2.gesture == "Lizard")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else if (player1.gesture == "Lizard" && player2.gesture == "Paper")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else if (player1.gesture == "Paper" && player2.gesture == "Spock")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else if (player1.gesture == "Spock" && player2.gesture == "Rock")
            {
                Console.WriteLine("Player 1 Wins Round!");
                player1.score++;
            }
            else
            {
                Console.WriteLine("Player 2 Wins Round!");
                player2.score++;
            }
        }

    }


}
