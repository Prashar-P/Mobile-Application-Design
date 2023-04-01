using Artistic.ViewModel;
using Microsoft.Maui.Controls;
using System.Reflection;

namespace Artistic;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
        BindingContext = new SettingsViewModel();
    }

}