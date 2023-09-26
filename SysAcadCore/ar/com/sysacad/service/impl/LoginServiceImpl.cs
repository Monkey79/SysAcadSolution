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
            Console.WriteLine("*******CheckCredential**********");
            _loginRepository.GetAll();
            return null;
        }
    }
}
