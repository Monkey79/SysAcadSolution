using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.repository;
using SysAcadCore.ar.com.sysacad.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.service.impl
{
    public class LoginServiceImpl : LoginService
    {
        private LoginRepository _loginRepository;
        public LoginServiceImpl() {
            _loginRepository = new LoginRepositoryImpl();
        }

        public User CheckCredential(string username, string password) {
            Console.WriteLine("****CheckCredential******");
            User user = _loginRepository.GetByUsername(username);
            if(user != null) {
                if (!string.Equals(user.Password, password)){
                    Console.WriteLine("err: usuario y/o contraseña incorrecto");
                }
            }else
                Console.WriteLine("err: el usuario NO existe");
            return user;
        }

        public bool Create(string username, string password, string role){
            User user = _loginRepository.GetByUsername(username);
            bool rsl = false;
            if (user == null){
                user = new User(username, password, role);
                rsl = _loginRepository.Save(user);
            }else {
                Console.WriteLine("err: el usuario {0} ya existe", username);
            }
            return rsl;
        }

        public List<User> GetAllUsers(){
            Console.WriteLine("****GetAllUsers******");
            return _loginRepository.GetAll();
        }
    }
}
