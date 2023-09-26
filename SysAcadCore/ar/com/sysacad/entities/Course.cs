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
        private string name;
        private string code;
        private string description;
        private int maxQuota;

        public Course(string name, string code, string description, int maxQuota)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.maxQuota = maxQuota;
        }

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public int MaxQuota { get => maxQuota; set => maxQuota = value; }
    }
}
