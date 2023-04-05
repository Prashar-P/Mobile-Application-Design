using Artistic.ViewModel;

namespace Artistic;

public partial class ViewItem : ContentPage
{
	public ViewItem()
	{
		InitializeComponent();
        BindingContext = new ViewItemViewModel();
    }

    //protected override void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //    Console.WriteLine(args);
    //}
}