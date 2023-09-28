using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad
{
    public abstract class SysAcadSystem
    {
       //protected CourseService _courseSrvc;

        protected List<Course> courses;
        protected User user;

        protected SysAcadSystem() {
            //_courseSrvc = new CouseServiceImpl();
            courses = new List<Course> ();
        }

        protected void AddCourse(Course course) { 
        
        }
        protected void RemoveCourse(Course course) {

        }
    }
}
