using Artistic.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artistic.Services
{
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
            Console.WriteLine("ADDEDUSER");
            Console.WriteLine(username);
            Console.WriteLine(password);
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Console.WriteLine(email);
            Console.WriteLine(phone);


            await Init();
            var users = new Users
            {

                Username = username,
                Password = password,
                FName = fname,
                LName = lname,
                Email = email,
                Phone = phone
            };

            var id = await db.InsertAsync(users);

        }

        public async Task RemoveUser(int id)
        {
            await Init();
                   
            await db.DeleteAsync<Users>(id);

        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            await Init();

            var users = await db.Table<Users>().ToListAsync();
            return users;

        }
    }

}