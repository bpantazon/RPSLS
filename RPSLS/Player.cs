using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variables
        public string name;
        public int score;
        public string usedGesture;
        //constructor
        public Player(string name, int score, string usedGesture)
        {
            this.name = name;
            this.score = score;
            this.usedGesture = usedGesture;

        }
        //member methods
        public void makeGesture()
        {
            Console.WriteLine("Player " + name + "used " + usedGesture + "!");
        }
    }
}
