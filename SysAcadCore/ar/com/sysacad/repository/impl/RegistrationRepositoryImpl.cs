using MySql.Data.MySqlClient;
using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository.impl
{
    public class RegistrationRepositoryImpl : BaseRepository, RegistrationRepository
    {
        private const string GET_ALL_BY_FILE_NUM = "SELECT * FROM registrations WHERE rg_st_file_number=@stdFilNm";

        public RegistrationRepositoryImpl() : base(){

        }

        public Registration DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Registration> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Registration> GetAllByFileNumber(int stdFileNm) {
            Console.WriteLine("*****[REPO] Registration.GetAllByFileNumber*******");
            List<Registration> registrations = new List<Registration>();
            Registration registration = null;
            try
            {
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_ALL_BY_FILE_NUM, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@stdFilNm", stdFileNm);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()) {
                    registration = new Registration();
                    registration.Id = _mySqlRead.GetInt32("id");
                    registration.StudentFileNumber = _mySqlRead.GetInt32("rg_st_file_number");
                    registration.CourseCode = _mySqlRead.GetInt32("rg_cr_code");
                    registration.SubjectName = _mySqlRead.GetString("rg_subject"); //nombre materia
                    registration.CreationDate = _mySqlRead.GetDateTime("rg_creation_date");
                    registration.From = _mySqlRead.GetDateTime("rg_from");
                    registration.Until = _mySqlRead.GetDateTime("rg_until");
                    registration.Shift = _mySqlRead.GetString("rg_shift");

                    registrations.Add(registration);
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return registrations;
        }

        public Registration GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Registration entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Registration entity)
        {
            throw new NotImplementedException();
        }
    }
}
