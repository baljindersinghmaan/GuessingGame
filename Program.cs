using GuessingGame;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random random = new Random();
int randomNumber = random.Next(1, 101);
int userGuessNumber;

List<Guess> guessesList = new List<Guess>();

do
{
    Console.WriteLine("Enter your guess in number format: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out userGuessNumber))
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }
    guessesList.Add(new Guess(userGuessNumber));

    if (userGuessNumber > randomNumber)
    {
        Console.WriteLine("Your guessed number is high");
    }
    else if (userGuessNumber < randomNumber)
    {
        Console.WriteLine("Your guessed number is low");
    }
    







} while (userGuessNumber != randomNumber);

Console.WriteLine($"Congratulations! The number is {userGuessNumber}.");
