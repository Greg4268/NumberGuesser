namespace NumGuesser
{
    public class Game
    {
        public void Play()
        {
            Console.Clear();
            int guess;
            int answer = GenerateNumber();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Guess a number between 1 - 10");
                string guessInput = Console.ReadLine();
                if (int.TryParse(guessInput, out guess))
                {
                    CheckGuess(guess, answer);
                }
                else
                {
                    System.Console.WriteLine("Invalid input, try again");
                }
            }
            Console.Clear();
            System.Console.WriteLine("Nice try, you lose!\nThe Answer was: " + answer);
            Thread.Sleep(1500);
            Utilities.DisplayMain();
        }

        public static int GenerateNumber()
        {
            Random rand = new Random();
            int answer = rand.Next(1, 11);
            return answer;
        }

        public void CheckGuess(int guess, int answer)
        {
            if (guess == answer)
            {
                Console.WriteLine("You Win!");
                Thread.Sleep(3500);
                Utilities.DisplayMain();
            }
            else if (guess != answer)
            {
                System.Console.WriteLine("You are incorrect!");
                HigherLower(guess, answer);
            }
        }

        public void HigherLower(int guess, int answer)
        {
            if (guess > answer)
            {
                Console.WriteLine("Hint: lower!");
            }
            else if (guess < answer)
            {
                Console.WriteLine("Hint: higher!");
            }
        }
    }
}