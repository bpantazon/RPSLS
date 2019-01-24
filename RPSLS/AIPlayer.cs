using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public AI(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override void MakeGesture()
        {
            Random r = new Random();

            List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            int x = r.Next(gestures.Count);
            usedGesture = gestures[x];
            
        }
    }
}
