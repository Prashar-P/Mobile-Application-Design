using Android.Media;
using Artistic.ViewModel;

namespace Artistic;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ViewItem), typeof(ViewItem));
        Routing.RegisterRoute(nameof(RegisterUser), typeof(RegisterUser));

    }
}
