using AbstractFactory.Main.Factory;
using System.Runtime.InteropServices;

IGUIFactory gUIFactory = null;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    gUIFactory = new WinFactory();
}
else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    gUIFactory = new MacFactory();
}
else
{
    throw new Exception("OS unknown");
}

GUIService gUIService = new(gUIFactory);
gUIService.Paint();