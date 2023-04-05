using MvvmHelpers.Commands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command = MvvmHelpers.Commands.Command;
using Artistic.Model;
using Artistic.Services;

namespace Artistic.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
            public ObservableRangeCollection<Users> Users { get; set; }
            public AsyncCommand<Users> CheckUserExist { get; }
            public string Username { get; set; }
            public string Password { get; set; }
            public MainPageViewModel()
            {

                Users = new ObservableRangeCollection<Users>();
                //RefreshCommand = new AsyncCommand(Refresh);
                CheckUserExist = new AsyncCommand<Users>(LoginUser);

            }

            async Task LoginUser(Users users)
            {
                if (await new UsersService().GetUser(Username,Password) == true)
                {
                    await Shell.Current.GoToAsync(nameof(BrowseItems));
                }
                else
                {
                }
            }

        }
}
