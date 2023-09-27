using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
  
    //table users
    public class User
    {
        public static string ADMIN_ROLE = "admin";
        public static string BASIC_ROLE = "basic";

        private int _id; //pk

        private string _name;
        private string _password;
        private string _role;
        private int _entityId;

        public User() { 

        }

        public User(string name, string password, string role, int entityId){
            _name = name;
            _password = password;
            _role = role;
            _entityId = entityId;
        }

        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }        
        public int EntityId { get => _entityId; set => _entityId = value; }
        public string Role { get => _role; set => _role = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
