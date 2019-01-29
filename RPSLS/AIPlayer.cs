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
            Random random = new Random();
            int x = random.Next(gestures.Count);
            usedGesture = gestures[x];
            
        }
    }
}
