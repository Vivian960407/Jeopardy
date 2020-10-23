using System.Text;

namespace JeopardyAssignment
{
    internal class Program
    {
        public static void Main()
        {
            WelcomeMessage.Welcome();
            var game = new Game();
            game.Menu_Switch();
        }
    }
}