using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public class Registration
    {
        private string _courseCode;
        private DateTime _from;
        private DateTime _until;

        public Registration(string courseCode, DateTime from, DateTime until) {
            _courseCode = courseCode;
            _from = from;
            _until = until;
        }

        public string CourseCode { get => _courseCode; set => _courseCode = value; }
        public DateTime From { get => _from; set => _from = value; }
        public DateTime Until { get => _until; set => _until = value; }
    }
}
