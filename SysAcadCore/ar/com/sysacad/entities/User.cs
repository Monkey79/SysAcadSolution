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
        private string _name; //is the user is a student his name will be the fileNumber (legajo)
        private string _password;
        private string _role;

        public User() { 

        }

        public User(string name, string password, string role){
            _name = name;
            _password = password;
            _role = role;            
        }

        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }                
        public string Role { get => _role; set => _role = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
