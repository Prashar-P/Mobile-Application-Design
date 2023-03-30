using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artistic.Model
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

    }
      
      
}
