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
    public class CourseServiceImpl : CourseService
    {
        private CourseRepository _courseRep;

        public CourseServiceImpl() {
            _courseRep = new CourseRepositoryImpl();
        }

        public bool Create(Course course) {
            bool result = false;
            Course courseNw = _courseRep.GetByCode(course.Code);
            if (courseNw != null){
                Console.WriteLine("err: el curso {0} ya existe ", course.Code);
            }else {
                result = _courseRep.Save(course);
            }
            return result;
        }

        public bool Remove(Course course) {
            bool result = false;
            Course courseNw = _courseRep.GetByCode(course.Code);
            if (courseNw == null){
                Console.WriteLine("err: el curso que quiere eliminar {0} NO existe ", course.Code);
            }else{
                result = _courseRep.DeleteByCode(course.Code);
            }
            return result;
        }
        public List<Course> GetAllCourses(){
            return _courseRep.GetAll();
        }

        public Course GetByCode(int code) {
            Course course = _courseRep.GetByCode(code);
            return course;
        }

        public bool Update(Course course){
            bool result = false;
            Course courseNw = _courseRep.GetByCode(course.Code);
            if (courseNw == null) {
                Console.WriteLine("err: el curso que quiere actualizar {0} NO existe ", course.Code);
            }else{
                result = _courseRep.Update(course);
            }
            return result;
        }
    }
}
