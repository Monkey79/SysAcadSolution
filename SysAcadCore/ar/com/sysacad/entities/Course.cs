using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public class Course
    {
        private int id; //pk
        private string _name;
        private int _code;
        private string _description;
        private int _maxQuota;
        private DateTime _from;
        private DateTime _until;
        private string _shift; //(M=Mañana T=Tarde N=Noche)

        public Course(){
        }

        public Course(int id, string name, int code, string description, int maxQuota, DateTime from, DateTime until, string shift){
            this.id = id;
            _name = name;
            _code = code;
            _description = description;
            _maxQuota = maxQuota;
            _from = from;
            _until = until;
            _shift = shift;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Code { get => _code; set => _code = value; }
        public string Description { get => _description; set => _description = value; }
        public int MaxQuota { get => _maxQuota; set => _maxQuota = value; }
        public DateTime From { get => _from; set => _from = value; }
        public DateTime Until { get => _until; set => _until = value; }
        public string Shift { get => _shift; set => _shift = value; }
    }
}
