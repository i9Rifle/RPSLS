using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public override void SetName()
        {
            Console.WriteLine("Type Player Name");
            name = Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose Gesture");
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            gesture = Console.ReadLine();
        }
    }
}
