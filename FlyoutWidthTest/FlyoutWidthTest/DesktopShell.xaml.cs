

namespace FlyoutWidthTest;

public partial class DesktopShell : Shell
{
	public DesktopShell()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        selectHour.SelectedItem = "1 hour";
    }

    void CollectionView_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
		var selection = e.CurrentSelection.FirstOrDefault() as string;
		switch(selection)
        {
			case "1 hour":
                this.CurrentItem = new OnePage();
                break;
            case "2 hours":
                this.CurrentItem = new TwoPage();
                break;
            case "4 hours":
                this.CurrentItem = new FourPage();
                break;

        }
    }
}
