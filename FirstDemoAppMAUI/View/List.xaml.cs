namespace FirstDemoAppMAUI.View;
using Microsoft.Maui.Controls;

public partial class List : ContentPage
{
	public List()
	{
		InitializeComponent();
	}

    private void btnGoToProductDetails_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}