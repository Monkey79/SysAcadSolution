using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.service;
using SysAcadCore.ar.com.sysacad.service.impl;
using System.Globalization;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;

namespace SysAcadAppCons
{
    internal class Program
    {
        private static LoginService _loginService;
        private static CourseService _courseService;

        //console project for testing purposes
        static void Main(string[] args){
            Console.WriteLine("*****SysAcadAppCons******");
            _loginService = new LoginServiceImpl();
            _courseService = new CourseServiceImpl();

            //Test_Wrong_GetUserByName();
            //Test_Correct_GetUserByName();
            //Test_Get_AllUsers();
            //Test_NO_EXIST_User();
            //Test_Get_AllUsers();

            //Test_Get_ALLCourses();
            //Test_Ge_CourseByCode();
            //Test_Creat_Course();
            //Test_Update_Course();
            Test_Update_NON_EXISTENT_Course();
        }

        //-----------------Courses
        static void Test_Update_Course() {
            Course course = _courseService.GetByCode(201);
            Console.WriteLine("voy a actualizar el curso {0} modificando el nombre", course.Code);
            course.Name = "algebra";
            bool rsl = _courseService.Update(course);
            Console.WriteLine("la acutalizacion del curso {0} fue exitosa?={1}", course.Code, rsl);
            course = _courseService.GetByCode(201);
            ShowACourse(course);

        }
        static void Test_Update_NON_EXISTENT_Course(){
            string fromStr = "2023-09-25 18:30:00";
            string untilStr = "2023-09-25 22:30:00";
            DateTime fromDT = DateTime.ParseExact(fromStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime untilDT = DateTime.ParseExact(untilStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Course course = new Course();
            course.Name = "algebra";
            course.Code = 2201;
            course.Description = "algebra analitica";
            course.MaxQuota = 100;
            course.From = fromDT;
            course.Until = untilDT;
            course.Shift = "N"; //M=morning F=afternoon N=night

            Console.WriteLine("voy a actualizar el curso {0} modificando el nombre", course.Code);
     
            bool rsl = _courseService.Update(course);
            Console.WriteLine("la acutalizacion del curso {0} fue exitosa?={1}", course.Code, rsl);   
        }
        static void Test_Creat_Course() {
            string fromStr = "2023-09-25 18:30:00";
            string untilStr = "2023-09-25 22:30:00";
            DateTime fromDT = DateTime.ParseExact(fromStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime untilDT = DateTime.ParseExact(untilStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Course course = new Course();
            course.Name = "algebra";
            course.Code = 201;
            course.Description = "algebra analitica";
            course.MaxQuota = 100;
            course.From = fromDT;
            course.Until = untilDT;
            course.Shift = "N"; //M=morning F=afternoon N=night

            Test_Get_ALLCourses();
            bool result = _courseService.Create(course);
            Console.WriteLine("se creo con exito {0}",result);
            Test_Get_ALLCourses();
        }
        static void Test_Get_ALLCourses() { 
            List<Course> courses = _courseService.GetAllCourses();
            ShowAllCourses(courses);
        }
        static void Test_Ge_CourseByCode() {
            int cCode = 101;
            Course course = _courseService.GetByCode(cCode);
            if(course!=null) ShowACourse(course);
        }
        static void ShowACourse(Course course){
            Console.WriteLine("course.name {0}", course.Name);
            Console.WriteLine("course.code {0}", course.Code);
            Console.WriteLine("course.description {0}", course.Description);
            Console.WriteLine("course.maximQuota {0}", course.MaxQuota);
            Console.WriteLine("course.from {0}", course.From);
            Console.WriteLine("course.until {0}", course.Until);
            Console.WriteLine("course.shift {0}", course.Shift);
        }
        static void ShowAllCourses(List<Course> courses){
            foreach(Course course in courses){
                Console.WriteLine("course.name {0}",course.Name);
                Console.WriteLine("course.code {0}", course.Code);
                Console.WriteLine("course.description {0}", course.Description);
                Console.WriteLine("course.maximQuota {0}", course.MaxQuota);
                Console.WriteLine("course.from {0}", course.From);
                Console.WriteLine("course.until {0}", course.Until);
                Console.WriteLine("course.shift {0}", course.Shift);
                Console.WriteLine("-----------------------------------");
            }
        }


        //------------------Login
        static void Test_NO_EXIST_User() {
            string user = "usuario22";
            string pss = "$$usuario22";
            string role = "admin";

            bool status = _loginService.Create(user, pss, role);
            Console.WriteLine("usuario {0} creado con exito={1}", user, status);
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