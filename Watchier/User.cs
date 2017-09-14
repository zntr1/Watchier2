using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchier
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte[] salt { get; set; }
        public byte[] passwordHash { get; set; }
        public string email { get; set; }

        // Constructor with Email
        public User(int id, string name, string email, byte[] salt, byte[] passwordHash)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.salt = salt;
            this.passwordHash = passwordHash;
        }

        // Constructor without Email
        public User(int id, string name, byte[] salt, byte[] passwordHash)
        {
            this.id = id;
            this.name = name;
            this.salt = salt;
            this.passwordHash = passwordHash;
        }

    }
}
