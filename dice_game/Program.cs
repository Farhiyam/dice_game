//Your Roll
//You rolled a 1 and a 1
//Total is 2

//Press any key...

// Computer's Roll
// Computer rolled a 3 and a 5
// Total is 8

//You Lost :(

//Play again? y or n

namespace dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Game! You will roll two dice, then the computer will roll two dice and we will see who wins.");

            Random rand = new Random();

            while (true)
            {
                //Variables for player's dice rolls
                int playerDice1 = rand.Next(1, 7);
                int playerDice2 = rand.Next(1, 7);


                //Variables for computer's dice rolls
                int computerDice1 = rand.Next(1, 7);
                int computerDice2 = rand.Next(1, 7);

                //Sum of player's dice rolls

                int playerTotal = playerDice1 + playerDice2;
                Console.WriteLine("You rolled a " + playerDice1 + " and a " + playerDice2 + " for a total score of  " + playerTotal);

                Thread.Sleep(2000);


                //Sum of computer's dice rolls
                int computerTotal = computerDice1 + computerDice2;
                Console.WriteLine("The computer rolled a " + computerDice1 + " and a " + computerDice2 + " for a total score of  " + computerTotal);

                //Determining the winner
                if (playerTotal > computerTotal)
                {
                    Console.WriteLine("You win! :)");
                }
                else if (playerTotal < computerTotal)
                {
                    Console.WriteLine("Sorry, the Computer wins :(");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                //Option to play the game again.
                Console.WriteLine("Would you like to play again? y/n");
                string playAgain = Console.ReadLine();

                //End the game if the player enters "n"

                if (playAgain == "n")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing");
            Console.ReadLine();

            
        }
    }
}

       





    
