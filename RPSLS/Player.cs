﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int score;
        public int randomNumber;
        public string gesture;
        public List<string> gestures;

        public Player()
        {
            gestures = new List<string> { $"Rock", "Paper", "Scissors", "Lizard", "Spock" };
            randomNumber = RNG;
        }

        public abstract void SetName();

        public abstract void ChooseGesture();

    }


    

    

    
}