using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public enum TYPE {
        FEE,
        SUBSCRITION
    }
    public class Payment
    {
        private TYPE _type;
        private float _value;
        private bool _settled;

        public Payment(TYPE type, float value, bool settled)
        {
            _type = type;
            _value = value;
            _settled = settled;
        }

        public TYPE Type { get => _type; set => _type = value; }
        public float Value { get => _value; set => _value = value; }
        public bool Settled { get => _settled; set => _settled = value; }
    }
}
