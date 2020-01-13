using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Players
    {
        public Human(string name)
        {
            this.name = (name);
            Console.WriteLine("Player 1");
        }
    }
}
