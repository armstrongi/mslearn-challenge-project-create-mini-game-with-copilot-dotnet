using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int wins = 0;
        int losses = 0;
        int draws = 0;
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Choose (R)ock, (P)aper, (S)cissors or (Q)uit: ");
            string userChoice = Console.ReadLine().ToLower();
            string[] options = { "rock", "paper", "scissors" };            
            Random random = new Random();
            string computerChoice = options[random.Next(0, 3)];

            switch (userChoice)
            {
                case "r":
                    userChoice = "rock";
                    break;
                case "p":
                    userChoice = "paper";
                    break;
                case "s":
                    userChoice = "scissors";
                    break;
                case "q":
                    userChoice = "quit";
                    break;
            }

            if (!Array.Exists(options, element => element == userChoice) && userChoice != "quit")
            {
                Console.WriteLine("Invalid choice, please choose (R)ock, (P)aper, (S)cissors or (Q)uit.");
                continue;
            }

            if(userChoice != "quit")
            {                            
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a draw!");
                    draws++;
                }
                else if ((userChoice == "rock" && computerChoice == "scissors") ||
                        (userChoice == "scissors" && computerChoice == "paper") ||
                        (userChoice == "paper" && computerChoice == "rock"))
                {
                    Console.WriteLine("You win!");
                    wins++;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    losses++;
                }

                Console.WriteLine($"Wins: {wins}, Losses: {losses}, Draws: {draws}");                                                
            }
            else
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}