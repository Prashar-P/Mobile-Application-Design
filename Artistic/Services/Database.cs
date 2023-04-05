using Artistic.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artistic.Services
{

    //Working with databases: https://www.youtube.com/watch?v=XFP8Np-uRWc&t=1041s&ab_channel=JamesMontemagno
    // Database creating and access is developed alongside this tutorial to allow user creation and auth.
    public class UsersService
    {

        SQLiteAsyncConnection db;

        async Task Init()
        {
            if (db != null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Users.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Users>();
        }

        public async Task AddUser(string username, string password, string fname, string lname, string email, string phone)
        {

            await Init();
            var user = new Users
            {

                Username = username,
                Password = password,
                FName = fname,
                LName = lname,
                Email = email,
                Phone = phone
            };



            var id = await db.InsertAsync(user);
            Console.WriteLine("User Created");

        }

        public async Task RemoveUser(int id)
        {
            await Init();
                   
            await db.DeleteAsync<Users>(id);

        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            await Init();

            var users = await db.Table<Users>().ToListAsync();
            return users;

        }
        
        public async Task<bool> GetUser(string username, string password)
        {
            await Init();
            var query = db.QueryAsync<Users>("SELECT EXISTS(SELECT 1 FROM [Users] WHERE [Username] =  ({username}) AND [Password] = ({password})) ");
            return true;

        }
    }

}