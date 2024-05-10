namespace NumGuesser
{
    public class Utilities
    {
        public static void DisplayMain()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Display();
        }

        public static void DisplayGame()
        {
            Game game = new Game();
            game.Play();
        }
    }
}