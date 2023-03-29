using CommunityToolkit.Mvvm.ComponentModel;
using  Artistic.Model;
using System.ComponentModel;

namespace Artistic.ViewModel;

using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Windows.Input;

public partial class BrowseItemsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Item> items;

    [ObservableProperty]
    Item item;

    public BrowseItemsViewModel()
    {
        LoadItems();
    }
    private void LoadItems()
    {

        Items = new()
        {
            new Item(

                Name: "Abstract Wallpaper",
                ProductImage: ImageSource.FromResource("Artistic.Resources.SampleItems.pexels_ann_h.jpg", typeof(BrowseItemsViewModel).GetTypeInfo().Assembly),
                Description: "Abstract Wallpaper Uploaded by Ann",
                Artist: "Ann H",
                UploadTime: DateTime.UtcNow.AddDays(1)
            ),
            new Item(
                Name: "Cherry Print Garment",
                ProductImage: ImageSource.FromResource("Artistic.Resources.SampleItems.pexels_eberhard_grossgasteiger.jpg", typeof(BrowseItemsViewModel).GetTypeInfo().Assembly),
                Description: "Teal and Pink Cherry Print Garment",
                Artist: "Eberhard Grossgasteiger",
                UploadTime: DateTime.UtcNow.AddDays(3).AddHours(2)
            ),
            new Item(
                Name: "Photo Of Painting",
                ProductImage: ImageSource.FromResource("Artistic.Resources.SampleItems.pexels_torsten_dettlaff.jpg", typeof(BrowseItemsViewModel).GetTypeInfo().Assembly),
                Description: "Close-Up Photo Of Painting",
                Artist: "Torsten Dettlaff",
                UploadTime: DateTime.UtcNow.AddDays(1).AddHours(6)
            )
        };
    }

    [RelayCommand]
    async Task Tap(object Item)
    {
        await Shell.Current.GoToAsync(nameof(ViewItem), new Dictionary<string, object>
        {
            { "item", Item }
        });
    }
}






