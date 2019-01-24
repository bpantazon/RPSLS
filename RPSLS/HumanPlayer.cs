using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human(string name, int score)
        {
            this.name = name;
            this.score = score;
           
        }

        public override void makeGesture()
        {
            Console.WriteLine("Which gesture would you like to use for this turn: Rock, Paper, Scissors, Lizard, or Spock?");
            usedGesture = Console.ReadLine();
            
        }
    }
}
