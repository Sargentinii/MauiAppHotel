namespace MauiAppHotel.Views;

public partial class sobrequartos : ContentPage
{
	public sobrequartos()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
