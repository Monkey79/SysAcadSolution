using MySql.Data.MySqlClient;
using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository.impl
{
    public class StudentRepositoryImpl : BaseRepository,StudentRepository
    {
        private const string GET_BY_FILE = "SELECT * FROM students WHERE st_file=@file";
        private const string SAVE = "INSERT INTO students (st_name, st_surname, st_address, st_phone_number, st_email_account, st_file, st_change_password) "+
                                    "VALUES (@name, @surname, @address, @phoneNumber, @email, @file, @changePassword)";
        public StudentRepositoryImpl() : base(){
            
        }

        public Student DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetByStudentFile(int file) {
            Console.WriteLine("*****[REPO] GetByStudentFile*******");
            Student student = null;
            try
            {
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_BY_FILE, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@file", file);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()){
                    student = new Student();
                    student.Id = _mySqlRead.GetInt32("id");
                    student.Name = _mySqlRead.GetString("st_name");
                    student.Surname = _mySqlRead.GetString("st_surname");
                    student.FileNumber = _mySqlRead.GetInt32("st_file");
                    student.Address = _mySqlRead.GetString("st_address");
                    student.PhoneNumber = _mySqlRead.GetString("st_phone_number");
                    student.Email = _mySqlRead.GetString("st_email_account");
                    student.ChangePassword = _mySqlRead.GetBoolean("st_change_password");
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return student;
        }

        public bool Save(Student student){
            Console.WriteLine("*****[REPO] Save*******");
            bool rslt = false;
            int rowsAffected = 0;
            try{
                _mySqlComnd = new MySqlCommand(SAVE, _mySqlConn);

                _mySqlComnd.Parameters.AddWithValue("@name", student.Name);
                _mySqlComnd.Parameters.AddWithValue("@surname", student.Surname);
                _mySqlComnd.Parameters.AddWithValue("@address", student.Address);
                _mySqlComnd.Parameters.AddWithValue("@phoneNumber", student.PhoneNumber);
                _mySqlComnd.Parameters.AddWithValue("@email", student.Email);
                _mySqlComnd.Parameters.AddWithValue("@file", student.FileNumber);
                _mySqlComnd.Parameters.AddWithValue("@changePassword", student.ChangePassword);

                rowsAffected = _mySqlComnd.ExecuteNonQuery();
                rslt = (rowsAffected > 0) ? true : false;              
            }catch (Exception ex){
                Console.WriteLine("err:"+ex.Message); 
            }finally { 
                _mySqlConn.Close();               
            }
            return rslt;
        }

        public bool Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
