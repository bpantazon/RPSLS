using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;
        public int numberOfPlayers;
        public string playerOneName;
        public string playerTwoName;
        //constructor
        public Game()
        {

        }
        //member methods
        public void getPlayers()
        {
            Console.WriteLine("How many players are there? Are there '1' or '2'?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the first player's name?");
            playerOneName = Console.ReadLine();
            Console.WriteLine("What is the second player's name?");
            playerTwoName = Console.ReadLine();
            if (numberOfPlayers == 1){
                playerOne = new Human(playerOneName, 0);
                playerTwo = new AI(playerTwoName, 0);
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human(playerOneName, 0);
                playerTwo = new AI(playerTwoName, 0);
            }
            else
            {
                getPlayers();
            }
            

        }

        public void displayRules()
        {
            Console.WriteLine("Scissors cuts PaperPaper covers Rock, Rock crushes Lizard,Lizard poisons Spock, Spock smashes Scissors,");
            Console.WriteLine("Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors");
        }
    }
}
