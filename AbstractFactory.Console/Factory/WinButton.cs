namespace AbstractFactory.Main.Factory
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Win button ...");
        }
    }
}