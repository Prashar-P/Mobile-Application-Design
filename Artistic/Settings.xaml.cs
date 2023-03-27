using Android.Content.Res;
using Artistic.ViewModel;
using Microsoft.Maui.Controls;
using System.Reflection;
using static Android.Content.Res.Resources;
using static Android.Graphics.ImageDecoder;

namespace Artistic;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
        BindingContext = new SettingsViewModel();
    }

}