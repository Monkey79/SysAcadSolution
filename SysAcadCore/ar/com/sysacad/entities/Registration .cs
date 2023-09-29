using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public class Registration
    {
        private int _id;
        private int _studentFileNumber; //fk (legajo)
        private int _courseCode; //fk (codigo del curso)
        private string _subjectName; //nombre del curso
        private DateTime _creationDate;
        private DateTime _from;
        private DateTime _until;
        private string _shift;

        public Registration() {
        }

        public Registration(int id, int studentFileNumber, int courseCode, string subjectName, DateTime creationDate, DateTime from, DateTime until, string shift = null)
        {
            _id = id;
            _studentFileNumber = studentFileNumber;
            _courseCode = courseCode;
            _subjectName = subjectName;
            _creationDate = creationDate;
            _from = from;
            _until = until;
            _shift = shift;
        }

        public int Id { get => _id; set => _id = value; }
        public int StudentFileNumber { get => _studentFileNumber; set => _studentFileNumber = value; }
        public int CourseCode { get => _courseCode; set => _courseCode = value; }
        public string SubjectName { get => _subjectName; set => _subjectName = value; }
        public DateTime CreationDate { get => _creationDate; set => _creationDate = value; }
        public DateTime From { get => _from; set => _from = value; }
        public DateTime Until { get => _until; set => _until = value; }
        public string Shift { get => _shift; set => _shift = value; }
    }
}
