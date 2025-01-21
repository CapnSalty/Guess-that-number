
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args, int gameState)
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 100);
        bool replay = true;
        int guess = 0;
        int attempts = 0;
        int maxAttempts = 10;
        string response;


        while (replay)
        {
            guess = 0;
            attempts = 0;
            maxAttempts = 10;
            targetNumber = random.Next(1, 100);
            response = "";

            Console.WriteLine("Welcome to GUESS THAT NUMBER!");
            Console.WriteLine("Please enter your name, contestant.");


            string userName = Console.ReadLine();


            Console.WriteLine("Welcome," + userName + "!");
            Console.WriteLine("Today you must guess a number between 0-100." +
                "You will only have {maxAttempts} to get it correct. Choose wisely.");


            while (guess != targetNumber)
            {
                Console.Write("What's your guess?");
                string input = Console.ReadLine();


                if (int.TryParse(input, out guess))
                {
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Nope! That's too low!");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Sorry, that's too high!");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You chose correctly!");

                        gameState++;
                    }

                }
                attempts++;

                if (attempts == maxAttempts)
                {
                    gameState++;

                    Console.WriteLine("Unfortunately, you're out of attempts." +
                        "The correct number was " + targetNumber);

                    Console.WriteLine("Play Again? Press R + Enter to replay!");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "R")
                    {
                        replay = true;
                    }
                    else
                    {
                        replay = false;
                    }

                    Console.WriteLine("Thanks for playing! See you next time!");
                }
            }
        }
    }
}