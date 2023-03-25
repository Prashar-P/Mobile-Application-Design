using CommunityToolkit.Mvvm.ComponentModel;
using  Artistic.Model;
using System.ComponentModel;

namespace Artistic.ViewModel;

using System.Reflection;

public partial class BrowseItemsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Item> items;

    public BrowseItemsViewModel()
    {
        LoadItems();
    }
    private void LoadItems()
    {

        Items = new()
        {
            new Item(

                Name: "Photograph of Watch",
                ProductImage: ImageSource.FromFile("C:\\Users\\Priya\\OneDrive\\Documents\\6002CEM\\Artistic\\Resources\\SampleItems\\pexels_cottonbro_studio.jpg"),
                Description: "Photograph of a black watch",
                Artist: "Joey Nguyen",
                UploadTime: DateTime.UtcNow.AddDays(1)
            ),
            new Item(
                Name: "Photograph of Phone",
                ProductImage: ImageSource.FromResource("Artistic.Resources.SampleItems.pexels_cottonbro_studio.jpg", typeof(BrowseItemsViewModel).GetTypeInfo().Assembly),
                Description: "Photograph of a Phone",
                Artist: "Gantas Valciulenas",
                UploadTime: DateTime.UtcNow.AddDays(3).AddHours(2)
            )
        };

    }

}

