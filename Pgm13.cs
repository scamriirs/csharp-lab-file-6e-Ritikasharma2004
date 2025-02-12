// create a game -rock -paper -scissor played between two player player1:computer player2:human use randam class
using System;

class RockPaperScissors
{
    static void Main()
    {
        string[] choices = { "Rock", "Paper", "Scissors" };

        Random rand = new Random();

        int computerChoiceIndex = rand.Next(0, 3);
        string computerChoice = choices[computerChoiceIndex];
        
        Console.WriteLine("Choose: Rock, Paper, or Scissors");
        string userChoice = Console.ReadLine();

        while (userChoice != "Rock" && userChoice != "Paper" && userChoice != "Scissors")
        {
            Console.WriteLine("Invalid choice. Please choose Rock, Paper, or Scissors.");
            userChoice = Console.ReadLine();
        }
        
        Console.WriteLine("Computer chose: " + computerChoice);
        Console.WriteLine("You chose: " + userChoice);


        if (computerChoice == userChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((computerChoice == "Rock" && userChoice == "Scissors") ||
                 (computerChoice == "Scissors" && userChoice == "Paper") ||
                 (computerChoice == "Paper" && userChoice == "Rock"))
        {
            Console.WriteLine("Computer wins!");
        }
        else
        {
            Console.WriteLine("You win!");
        }
    }
}
