using Artistic.ViewModel;

namespace Artistic;

public partial class RegisterUser : ContentPage
{
	public RegisterUser()
	{
		InitializeComponent();
        BindingContext = new RegisterUserViewModel();

    }

}