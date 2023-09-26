using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public enum ROLE {
        ADMIN,
        BASIC
    }
    public class User
    {
        private string _name;
        private string _password;
        private ROLE _role;

        private int _entityId; //TODO ver

        public User(string name, string password, ROLE role, int entityId){
            Name = name;
            Password = password;
            Role = role;
            EntityId = entityId;
        }

        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public ROLE Role { get => _role; set => _role = value; }
        public int EntityId { get => _entityId; set => _entityId = value; }
    }
}
