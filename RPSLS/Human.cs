using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human()
        {
            SetName();
        }
        public override void SetName()
        {
            Console.WriteLine("Type Player Name");
            name = Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            //In case of invalid gesture user input
            bool isTrue = false;
            while (isTrue == false)
            {
                Console.WriteLine("Choose Gesture");
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
                gesture = Console.ReadLine();
                if (gestures.Contains(gesture))
                {
                    isTrue = true;
                }
                else
                {
                    Console.WriteLine("Not valid Gesture try again!");
                }
            }
        }        
    }
}
