namespace AbstractFactory.Main.Factory
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Mac button ...");
        }
    }
}