using Artistic.ViewModel;

namespace Artistic;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ViewItem), typeof(ViewItem));
        Routing.RegisterRoute(nameof(RegisterUser), typeof(RegisterUser));
        Routing.RegisterRoute(nameof(BrowseItems), typeof(BrowseItems));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(Settings), typeof(Settings));


    }
}
