using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.dto
{
    public class StudentDto
    {
        private string _name;
        private string _surname;
        private string _address;
        private string _phoneNumber;
        private string _email;

        private int _file; //legajo
        private bool _changePassword;

        public StudentDto(string name, string surname, string address, string phoneNumber, string email, int file, bool changePassword = false)
        {
            _name = name;
            _surname = surname;
            _address = address;
            _phoneNumber = phoneNumber;
            _email = email;
            _file = file;
            _changePassword = changePassword;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Address { get => _address; set => _address = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }
        public int File { get => _file; set => _file = value; }
        public bool ChangePassword { get => _changePassword; set => _changePassword = value; }
    }
}
