namespace AbstractFactory.Main.Factory
{
    public interface IGUIFactory
    {
        IButton CreateButton();

        ICheckBox CreateCheckBox();
    }
}