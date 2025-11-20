namespace MauiAppHotel.Views;

public class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}