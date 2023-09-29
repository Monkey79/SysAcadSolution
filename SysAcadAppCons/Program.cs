using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.service;
using SysAcadCore.ar.com.sysacad.service.impl;

namespace SysAcadAppCons
{
    internal class Program
    {
        private static LoginService _loginService;

        //console project for testing purposes
        static void Main(string[] args){
            Console.WriteLine("*****SysAcadAppCons******");
            _loginService = new LoginServiceImpl();

            //Test_Wrong_GetUserByName();
            //Test_Correct_GetUserByName();
            Test_Get_AllUsers();
            //Test_NO_EXIST_User();
            //Test_Get_AllUsers();
        }


        //------------------Login
        static void Test_NO_EXIST_User() {
            bool status = _loginService.Create("usuario22", "$$usuario22","Admin");
            Console.WriteLine("usuario {0} creado con exito =","usuario22", status);
        }
        static void Test_Get_AllUsers() {
            showAllUsers(_loginService.GetAllUsers());
        }
        static void Test_Wrong_GetUserByName() {
            User user = _loginService.CheckCredential("wrong", "wrong");                   
        }
        static void Test_Correct_GetUserByName(){
            User user = _loginService.CheckCredential("12345", "Contraseña2");
            if (user != null){
                Console.WriteLine("user.id " + user.Id);
                Console.WriteLine("user.name " + user.Name);
                Console.WriteLine("user.password " + user.Password);
                Console.WriteLine("user.role " + user.Role);
            }
        }

        static void showAllUsers(List<User> users){
            foreach(User user in users) {
                Console.WriteLine("user.id "+user.Id);
                Console.WriteLine("user.name " + user.Name);
                Console.WriteLine("user.password " + user.Password);
                Console.WriteLine("user.role " + user.Role);
            }
        }
    }
}