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
    public abstract class SysAcadSystem
    {
        protected CourseService _courseSrvc;

        protected List<Course> _courses;
        protected User _user;

        public SysAcadSystem(User user) {
            _user = user;
            _courseSrvc = new CourseServiceImpl();
            _courses = new List<Course> ();
        }

        public void AddCourse(Course course) {
            _courseSrvc.Create(course);
        }
        public void UpdateCourse(Course course) {
            _courseSrvc.Update(course);
        }
        public void DeleteCourse(Course course) {
            _courseSrvc.Remove(course);
        }
    }
}
