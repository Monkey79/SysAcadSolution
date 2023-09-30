using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.repository;
using SysAcadCore.ar.com.sysacad.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.service.impl
{
    public class PaymentServiceImpl : PaymentService
    {
        private PaymentRepository _paymentRep;

        public PaymentServiceImpl() {
            _paymentRep = new PaymentRepositoryImpl();
        }

        public List<Payment> GetAllPaymentsOfAStudent(int stdFileNm){
            List<Payment> payments = _paymentRep.GetByFileNumber(stdFileNm);
            return payments;
        }
    }
}
