
using Artistic.ViewModel;

namespace Artistic;

public partial class BrowseItems : ContentPage
{

    public BrowseItems()
    {
        InitializeComponent();
        BindingContext = new BrowseItemsViewModel();

    }

}