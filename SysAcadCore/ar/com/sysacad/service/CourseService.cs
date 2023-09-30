using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.service
{
    public interface CourseService
    {
        public bool Create(Course course);
        public bool Remove(Course course);
        public List<Course> GetAllCourses();
        public Course GetByCode(int code);
        public bool Update(Course course);
    }
}
