using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Linq;
using System.Threading.Tasks;
using Command = MvvmHelpers.Commands.Command;
using Artistic.Model;
using Artistic.Services;

using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;


namespace Artistic.ViewModel
{
    public class RegisterUserViewModel : MainViewModel
    {
        public ObservableRangeCollection<Users> Users { get; set; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Users> RemoveCommand { get; }
        public AsyncCommand RefreshCommand { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public RegisterUserViewModel()
        {

            Users = new ObservableRangeCollection<Users>();
            //RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(RegUser);
            RemoveCommand = new AsyncCommand<Users>(Remove);

        }

        async Task RegUser()
        {
            await new UsersService().AddUser(Username, Password, FName, LName, Email, Phone);
        }

        async Task Remove(Users users)
        {
            await new UsersService().RemoveUser(users.Id);
        }


    }
}
