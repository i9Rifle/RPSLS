using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public static class UserInterface
    {
        public static void DisplayIntro()
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
    }
}
