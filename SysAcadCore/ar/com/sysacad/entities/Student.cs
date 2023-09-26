using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.entities
{
    public class Student
    {
        private int _id; //pk

        private string _name;
        private string _surname;
        private string _address;
        private string _phoneNumber;
        private string _email;

        private List<Payment> _payments;
        private List<Registration> _registrations;

        public Student(string name, string surname, string address, string phoneNumber, string email)
        {
            _name = name;
            _surname = surname;
            _address = address;
            _phoneNumber = phoneNumber;
            _email = email;

            _payments = new List<Payment>();
            _registrations = new List<Registration>();
        }

        public int Id { get => _id; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Address { get => _address; set => _address = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }

        public List<Payment> Payments { get => _payments; }
        public List<Registration> Registrations { get => _registrations; }

        public void AddPayment(Payment payment) { _payments.Add(payment); }
        public void AddRegistration(Registration registration) { _registrations.Add(registration); }
    }
}
