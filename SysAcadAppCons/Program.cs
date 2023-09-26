using SysAcadCore.ar.com.sysacad.service;
using SysAcadCore.ar.com.sysacad.service.impl;

namespace SysAcadAppCons
{
    internal class Program
    {
        //console project for testing purposes
        static void Main(string[] args){
            Console.WriteLine("*****SysAcadAppCons******");
            LoginService loginService = new LoginServiceImpl();
            loginService.CheckCredential("pepe", "pepe");
        }
    }
}