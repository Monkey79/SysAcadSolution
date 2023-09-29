using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public class Payment
    {
        private int _id;
        private int _studentFileNumber; //fk (legajo)
        private string _concept; //matricula - cuota
        private float _amount;
        private bool _settled;

        public Payment() {
        }

        public Payment(int id, int studentFileNumber, string concept, float amount, bool settled){
            _id = id;
            _studentFileNumber = studentFileNumber;
            _concept = concept;
            _amount = amount;
            _settled = settled;
        }

        public int Id { get => _id; set => _id = value; }
        public int StudentFileNumber { get => _studentFileNumber; set => _studentFileNumber = value; }
        public string Concept { get => _concept; set => _concept = value; }
        public float Amount { get => _amount; set => _amount = value; }
        public bool Settled { get => _settled; set => _settled = value; }
    }
}
