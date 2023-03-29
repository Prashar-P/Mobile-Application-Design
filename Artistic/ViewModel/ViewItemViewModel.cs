using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artistic.Model;

namespace Artistic.ViewModel;


[QueryProperty(nameof(Item), "item")]
public partial class ViewItemViewModel : BrowseItemsViewModel
{

}

