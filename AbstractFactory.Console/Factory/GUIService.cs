namespace AbstractFactory.Main.Factory
{
    public class GUIService
    {
        private readonly IGUIFactory _factory;
        private IButton _button;
        private ICheckBox _checkBox;

        public GUIService(IGUIFactory factory)
        {
            _factory = factory;
            CreateUI();
        }

        private void CreateUI()
        {
            _button = _factory.CreateButton();
            _checkBox = _factory.CreateCheckBox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkBox.Paint();
        }
    }
}