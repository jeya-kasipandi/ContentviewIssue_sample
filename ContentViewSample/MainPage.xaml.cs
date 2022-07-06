namespace ContentViewSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        contentView.HeightRequest += 200;
        contentView.WidthRequest += 200; 


    }

	private void contentView_SizeChanged(object sender, EventArgs e)
	{
        System.Diagnostics.Debug.WriteLine("Size is changed");

    }
}

