namespace GuessingGame
{
    public class Guess
    {
        public int UserGuess { get; }
        public DateTime GuessTime { get; }
        int UserGuessNumber;

        List<Guess> guessesList = new List<Guess>();



        public Guess(int userGuess)
        {
            UserGuess = userGuess;
            GuessTime = DateTime.Now;
        }

       

    }
}
