
namespace NumGuesser
{
    public class MainMenu
    {
        public void Display()
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to the Number Guessing Game!");
            System.Console.WriteLine("\n Would you like to play? (y/n)");
            string answer = Console.ReadLine();
            HandleUserInput(answer);
        }

        public void HandleUserInput(string answer)
        {
            if (answer.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Utilities.DisplayGame();
            }
            else if (answer.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Exiting...");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("Please enter a valid option!");
                Thread.Sleep(1000);
                Console.Clear();
                Display();
            }
        }
    }
}