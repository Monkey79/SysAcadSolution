using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository
{
    public interface CourseRepository : CrudOperation<Course>
    {
        public Course GetByCode(int code);
        public bool DeleteByCode(int code);
    }
}
