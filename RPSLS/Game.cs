﻿using System;
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
        //public List<string> players = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        List<string> numberOfPlayersOption = new List<string>() { "1", "2" };
        string playerOneName;
        string playerTwoName;
       
        //constructor
        public Game()
        {
     
        }
        //member methods


        public void PlayGame()
        {
            DisplayRules();
            GetPlayers();
            PlayRound();
            AskToRestartGame();
        }
        public void AskForPlayerOne()
        {
            Console.WriteLine("What is the first player's name?");
            playerOneName = Console.ReadLine();
            CheckPlayerOneName();
        }
        public void CheckPlayerOneName()
        {
           
            
            if (playerOneName == string.Empty)
            {
                Console.WriteLine("Player needs a name");
                Console.ReadLine();
                AskForPlayerOne();
            }

        }
        public void AskForPlayerTwo()
        {
            Console.WriteLine("What is the second player's name?");
            playerTwoName = Console.ReadLine();
            CheckPlayerTwoName();
        }
        public void CheckPlayerTwoName()
        {
            
            if (playerTwoName == string.Empty)
            {
                Console.WriteLine("Player needs a name");
                Console.ReadLine();
                AskForPlayerTwo();
            }
        }
      
        public void GetPlayers()
        {
            Console.WriteLine("How many players are there? Are there '1' or '2'?");
            try
            {  
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter an integer of '1' or '2'");
                GetPlayers();
            }
            if (numberOfPlayers < 1 || numberOfPlayers > 2)
            {
                Console.WriteLine("Enter '1' or '2'");
                GetPlayers();
            }
            AskForPlayerOne();          
            AskForPlayerTwo();       
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
        
        public void PlayRound()
        {
            playerOne.MakeGesture();
            playerTwo.MakeGesture();
            CheckGestures();
            CheckPlayerScore();
        }
        public void AskToRestartGame()
        {
            string restartGame;
            Console.WriteLine("Would you like to play another game? Type 'yes' if you do.");
            
                restartGame = Console.ReadLine();
            
                Console.WriteLine("Write 'yes' or 'no'");
                AskToRestartGame();
            
            if (restartGame == "yes")
            {
                playerOne.usedGesture = null;
                playerOne.name = null;
                playerOne.score = 0;
                playerTwo.usedGesture = null;
                playerTwo.name = null;
                playerTwo.score = 0;
                PlayGame();
            }

        }
        public void CheckPlayerScore()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " wins the game!");
                Console.ReadLine();
                playerOne.score = 0;
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo.name + " wins the game!");
                Console.ReadLine();
                playerTwo.score = 0;
            }
            else
            {
                playerOne.usedGesture = null;
                playerTwo.usedGesture = null;
                PlayRound();

            }
        }

        public void CheckGestures()
        {
            if (playerOne.usedGesture == playerTwo.usedGesture)
            {
                DeclarePlayerOneGesture();
                DeclarePlayerTwoGesture();
                Console.WriteLine("It is a tie. Try again");
                Console.ReadLine();
                PlayRound();
            }
            else if (playerOne.usedGesture == "rock")
            {
                DeclarePlayerOneGesture();

                if (playerTwo.usedGesture == "paper" || playerTwo.usedGesture == "spock")
                    {
                    DeclarePlayerTwoGesture();
                    GivePlayerTwoPoint();
                    }
                    else if (playerTwo.usedGesture == "scissors" || playerTwo.usedGesture == "lizard")
                    {
                    DeclarePlayerTwoGesture();
                    GivePlayerOnePoint();
                    }
            }
            else if (playerOne.usedGesture == "paper")
            {
                DeclarePlayerOneGesture();

                if (playerTwo.usedGesture == "rock" || playerTwo.usedGesture == "spock")
                    {
                    DeclarePlayerTwoGesture();
                    GivePlayerOnePoint();
                    }
                    else if (playerTwo.usedGesture == "scissors" || playerTwo.usedGesture == "lizard")
                    {
                    DeclarePlayerTwoGesture();
                    GivePlayerTwoPoint();
                    }
            
            }
            else if (playerOne.usedGesture == "scissors")
            {
                DeclarePlayerOneGesture();

                if (playerTwo.usedGesture == "paper" || playerTwo.usedGesture == "lizard")
                    {
                    DeclarePlayerTwoGesture();
                    GivePlayerOnePoint();
                }
                    else if (playerTwo.usedGesture == "rock" || playerTwo.usedGesture == "spock")
                    {
                    DeclarePlayerTwoGesture();
                    GivePlayerTwoPoint();
                }
            }
           
            else if (playerOne.usedGesture == "lizard")
            {
                DeclarePlayerOneGesture();
                
                if (playerTwo.usedGesture == "paper" || playerTwo.usedGesture == "spock")
                {
                    DeclarePlayerTwoGesture();
                    GivePlayerOnePoint();
                }
                else if (playerTwo.usedGesture == "rock" || playerTwo.usedGesture == "scissors")
                {
                    DeclarePlayerTwoGesture();
                    GivePlayerTwoPoint();
                }
            }
            else if (playerOne.usedGesture == "spock")
            {
                DeclarePlayerOneGesture();
                
                if (playerTwo.usedGesture == "scissors" || playerTwo.usedGesture == "rock")
                {
                    DeclarePlayerTwoGesture();
                    GivePlayerOnePoint();
                }
                else if (playerTwo.usedGesture == "paper" || playerTwo.usedGesture == "lizard")
                {
                    DeclarePlayerTwoGesture();
                    GivePlayerTwoPoint();
                }
            }            
        }
        
        public void DeclarePlayerTwoGesture()
        {
            Console.WriteLine(playerTwo.name + " used " + playerTwo.usedGesture);
            Console.ReadLine();
        }
        public void GivePlayerTwoPoint()
        {
            Console.WriteLine(playerTwo.name + " wins! " + playerTwo.name + " earned 1 point!");
            Console.ReadLine();
            playerTwo.score++;
        }
        public void DeclarePlayerOneGesture()
        {
            Console.WriteLine(playerOne.name + " used " + playerOne.usedGesture);
            Console.ReadLine();
        }
        public void GivePlayerOnePoint()
        {
            Console.WriteLine(playerOne.name + " wins! " + playerOne.name + " earned 1 point!");
            Console.ReadLine();
            playerOne.score++;
        }


        public void DisplayRules()
        {
            Console.WriteLine("Rules: Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors,");
            Console.WriteLine("Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors");
            Console.ReadLine();
        }
    }
}
