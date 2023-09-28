using SysAcadCore.ar.com.sysacad.dto;
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
    public class StudentServiceImpl : StudentService
    {
        private StudentRepository _studenRep;

        public StudentServiceImpl(){
            _studenRep = new StudentRepositoryImpl();
        }

        public bool CreateStudent(StudentDto studentDto) {
            Student student = _studenRep.GetByStudentFile(studentDto.File); //legajo
            bool saveRsl = false;

            if (student == null) {
                student = new Student();
                student.Name = studentDto.Name;
                student.Surname = studentDto.Surname;
                student.Email = studentDto.Email;
                student.File   = studentDto.File;
                student.Address = studentDto.Address;
                student.PhoneNumber = studentDto.PhoneNumber;
                student.ChangePassword = studentDto.ChangePassword;

                saveRsl = _studenRep.Save(student);
            }else {
                Console.WriteLine("El estudiante con legajo {0} ya existe ", studentDto.File);
            }
            return saveRsl;            
        }
    }
}
