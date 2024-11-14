using GuessingGame;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random random = new Random();
int randomNumber = random.Next(1, 101);
int userGuessNumber;
        
List<Guess> guessesList = new List<Guess>();

do {
    Console.WriteLine("Enter your guess in number format: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out userGuessNumber))
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }
    

    



} while (userGuessNumber != randomNumber);