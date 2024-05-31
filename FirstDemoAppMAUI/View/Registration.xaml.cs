namespace FirstDemoAppMAUI.View;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private async void SelectBarcode(object sender, EventArgs e)
    {
        var images = await FilePicker.Default.PickAsync(new PickOptions
        {
            PickerTitle = "Pick Barcode/QR Code Image",
            FileTypes = FilePickerFileType.Images
        });
        var imageSource = images.FullPath.ToString();
        //barcodeImage.Source = imageSource;
        outputText.Text = imageSource;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}