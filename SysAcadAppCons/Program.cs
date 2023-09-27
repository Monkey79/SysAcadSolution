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

            //TestGetUserByName();
            TestGetAllUsers();
        }

        static void TestGetAllUsers() {
            showAllUsers(_loginService.GetAllUsers());
        }
        static void TestGetUserByName() {
            _loginService.CheckCredential("user2", "pepe");
        }

        static void showAllUsers(List<User> users){
            foreach(User user in users) {
                Console.WriteLine("user.id "+user.Id);
                Console.WriteLine("user.name " + user.Name);
                Console.WriteLine("user.password " + user.Password);
                Console.WriteLine("user.role " + user.Role);
                Console.WriteLine("user.entity_id " + user.EntityId);                
            }
        }
    }
}