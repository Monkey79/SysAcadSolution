using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.service;
using SysAcadCore.ar.com.sysacad.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.business.impl
{
    public class StudentBusinessImpl : StudentBusiness
    {
        private StudentService _studentSrvc;
        private PaymentService _paymentSrvc;
        private RegistrationService _registrationSrvc;

        public StudentBusinessImpl() {
            _studentSrvc = new StudentServiceImpl();
            _paymentSrvc = new PaymentServiceImpl();
            _registrationSrvc = new RegistrationServiceImpl();
        }

        public Student GetCompleteStudentByFileNumber(int fileNumber) {
            Student student = _studentSrvc.GetStudentByFileNumber(fileNumber);
            List<Payment> payments = null;
            List<Registration> registrations = null;

            if (student == null){
                Console.WriteLine("El estudiante con legajo {0} NO existe ", fileNumber);
            }else {
                payments = _paymentSrvc.GetAllPaymentsOfAStudent(student.FileNumber);
                registrations = _registrationSrvc.GetAllRegistrationOfAStudent(student.FileNumber);

                student.Payments = payments;
                student.Registrations = registrations;
            }
            return student;
        }
    }
}
