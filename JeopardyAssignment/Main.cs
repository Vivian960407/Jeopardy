namespace JeopardyAssignment
{
    internal class Program
    {
        public static void Run()
        {
            var game = new Game();
            game.Menu_Switch();
        }
        public static void Main()
        {
            WelcomeMessage.Welcome();
            Run();
        }
    }
}