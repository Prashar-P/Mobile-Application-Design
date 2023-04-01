using Artistic.ViewModel;

namespace Artistic;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    async void RegisterButton(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegisterUser));
    }

   
}