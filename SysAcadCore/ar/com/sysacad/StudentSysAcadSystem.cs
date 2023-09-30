using SysAcadCore.ar.com.sysacad.business;
using SysAcadCore.ar.com.sysacad.business.impl;
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
    public class StudentSysAcadSystem : SysAcadSystem
    {
        private StudentBusiness _studentBsn;
        private Student _student;

        public StudentSysAcadSystem(User user) :base (user) {
            _studentBsn = new StudentBusinessImpl();
            
            GetStudent();
        }

        private void GetStudent() {
            int stFileNm = 0;
            try {
                stFileNm = int.Parse(_user.Name); //si el usuario creado es un estudiante su nombre de usuario sera su legajo
                _student = _studentBsn.GetCompleteStudentByFileNumber(stFileNm);
            }catch (FormatException ex){
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
