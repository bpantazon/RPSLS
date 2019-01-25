using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        //member variables
        public string name;
        public int score;
        public string usedGesture;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        //constructor
        public Player()
        {
            
        }
        //member methods
        public virtual void MakeGesture()
        {
           
           
        }
    }
}
