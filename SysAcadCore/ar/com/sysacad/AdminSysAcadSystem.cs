using SysAcadCore.ar.com.sysacad.dto;
using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.service;
using SysAcadCore.ar.com.sysacad.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad
{
    //Only ADMIN
    public class AdminSysAcadSystem : SysAcadSystem
    {
        private StudentService _studentSrvc;
        private List<Student> _students;
        

        public AdminSysAcadSystem(User user):base(user) {
            _students = new List<Student>();
            _studentSrvc = new StudentServiceImpl();
        }

        public bool AddStudent(StudentDto studentDto){
            return _studentSrvc.CreateStudent(studentDto);
        }
        public void RemoveStudent(Student student)
        {

        }
        public void EditStudent(Student student) { 

        }
    }
}
