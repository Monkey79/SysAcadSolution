using MySql.Data.MySqlClient;
using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository.impl
{
    public class PaymentRepositoryImpl : BaseRepository, PaymentRepository
    {
        private const string GET_ALL_BY_FILE_NUM = "SELECT * FROM payments WHERE py_st_file_number=@fileNum";
        public PaymentRepositoryImpl():base() {

        }

        public Payment DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetByFileNumber(int stdFileNm) {
            Console.WriteLine("*****[REPO] Payment.GetByFileNumber*******");
            List<Payment> payments = new List<Payment>();
            Payment payment = null;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_ALL_BY_FILE_NUM, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@fileNum", stdFileNm);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()){
                    payment = new Payment();
                    payment.Id = _mySqlRead.GetInt32("id");
                    payment.StudentFileNumber = _mySqlRead.GetInt32("py_st_file_number");
                    payment.Concept = _mySqlRead.GetString("py_concept");
                    payment.Amount = _mySqlRead.GetInt32("py_amount");
                    payment.Settled = _mySqlRead.GetBoolean("py_settled");

                    payments.Add(payment);
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return payments;
        }

        public Payment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Payment entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Payment entity)
        {
            throw new NotImplementedException();
        }
    }
}
