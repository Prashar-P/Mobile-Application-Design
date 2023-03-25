namespace Artistic;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

    }

    async void LoginButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BrowseItems());
    }

}

