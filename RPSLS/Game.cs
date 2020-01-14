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
                    }

    }


}
