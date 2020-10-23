using System.Security.Cryptography.X509Certificates;

namespace JeopardyAssignment
{
    internal class Program
    {
        public static void Main()
        {
            WelcomeMessage.Welcome();
            NewGame();
        }
        public static void NewGame()
        {
            var game = new Game();
            game.Start();
        }
    }
}