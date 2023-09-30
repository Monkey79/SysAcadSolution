using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.business
{
    public interface StudentBusiness
    {
        public Student GetCompleteStudentByFileNumber(int fileNumber);
    }
}
