using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class CPU : Player
    {
        public override void SetName()
        {
            name = "Dorian";
        }
        public override void ChooseGesture()
        {
            Random rng = new Random();
            int randomNumber = rng.Next(gestures.Count);
            gesture = gestures[randomNumber];
        }

    }
}
