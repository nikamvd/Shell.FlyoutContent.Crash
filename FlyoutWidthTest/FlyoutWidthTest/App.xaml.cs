namespace FlyoutWidthTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var desktopShellViewModel = new DesktopShellViewModel();
        var desktopShell = new DesktopShell();
        desktopShell.BindingContext = desktopShellViewModel;
        MainPage = desktopShell;
    }
}

