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

        public override void MakeGesture()
        {
            int i;
            Console.WriteLine("Which gesture would you like to use for this turn? Type '0' for Rock, '1' for Paper, '2' for Scissors, '3' for Lizard, and '4' for Spock");

            //doesn't catch for out of range index
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                usedGesture = gestures[i];
            } 
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Stop it. Just, stop it. Choose an option from 0 to 4");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Staaaaahp. Error: Must enter an integer");
                Console.ReadLine();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Put something in there");
                Console.ReadLine();
            }
            


        }
    }
}
