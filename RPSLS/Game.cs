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
        //public string playerOneName;
        //public string playerTwoName;
        //constructor
        public Game()
        {

        }
        //member methods
        public void GetPlayers()
        {
            Console.WriteLine("How many players are there? Are there '1' or '2'?");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the first player's name?");
            string playerOneName = Console.ReadLine();
            Console.WriteLine("What is the second player's name?");
            string playerTwoName = Console.ReadLine();
            if (numberOfPlayers == 1){
                playerOne = new Human(playerOneName, 0);
                playerTwo = new AI(playerTwoName, 0);
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human(playerOneName, 0);
                playerTwo = new Human(playerTwoName, 0);
            }
            else
            {
                GetPlayers();
            }
            

        }

        public void CheckGestures() //need to add score 
        {
            if (playerOne.usedGesture == "rock")
            {
                Console.WriteLine(playerOne.name + " used " + playerOne.usedGesture);
                    if (playerTwo.usedGesture == "rock")
                    {
                        Console.WriteLine(playerTwo.name + " used " + playerTwo.usedGesture);
                        Console.WriteLine("It is a tie");
                    }
                    else if (playerTwo.usedGesture == "paper" || playerTwo.usedGesture == "spock")
                    {
                        Console.WriteLine(playerTwo.name + " used " + playerTwo.usedGesture);
                        Console.WriteLine(playerTwo.name + " wins! " + playerTwo.name +" earned 1 point!");
                    }
                    else if (playerTwo.usedGesture == "scissors" || playerTwo.usedGesture == "lizard")
                    {
                        Console.WriteLine(playerOne.name + " used " + playerTwo.usedGesture);
                        Console.WriteLine(playerOne.name + " wins! " + playerOne.name + "earned 1 point!");
                    }
            }
            else if (playerOne.usedGesture == "paper")
            {
                Console.WriteLine(playerOne.name + " used " + playerOne.usedGesture);
                    if (playerTwo.usedGesture == "paper")
                    {
                        Console.WriteLine(playerTwo.name + " used " + playerTwo.usedGesture);
                        Console.WriteLine("It is a tie");
                    }
                    else if (playerTwo.usedGesture == "rock" || playerTwo.usedGesture == "spock")
                    {
                        Console.WriteLine(playerTwo.name + " used " + playerTwo.usedGesture);
                        Console.WriteLine(playerOne.name + " wins! " + playerOne.name + " earned 1 point!");
                    }
                    else if (playerTwo.usedGesture == "scissors" || playerTwo.usedGesture == "lizard")
                    {
                        Console.WriteLine(playerTwo.name + " used " + playerTwo.usedGesture);
                        Console.WriteLine(playerTwo.name + " wins! " + playerTwo.name + "earned 1 point!");
                    }
            
            }
            else if (playerOne.usedGesture == "scissors")
                
        }


        public void DisplayRules()
        {
            Console.WriteLine("Scissors cuts PaperPaper covers Rock, Rock crushes Lizard,Lizard poisons Spock, Spock smashes"+"\n"+ "Scissors,");
            Console.WriteLine(" Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors");
        }
    }
}
