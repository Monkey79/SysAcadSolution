using MySql.Data.MySqlClient;
using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SysAcadCore.ar.com.sysacad.repository.impl
{
    public class CourseRepositoryImpl : BaseRepository, CourseRepository
    {
        private const string GET_BY_CODE = "SELECT * FROM courses WHERE cr_code=@code";

        private const string GET_ALL = "SELECT * FROM courses";

        private const string INSERT = "INSERT INTO courses (cr_name, cr_code, " +
            "cr_description, cr_maximum_quota, " +
            "cr_from, cr_until, cr_shift) " +
            "VALUES (@name, @code, @description, " +
            "@maximumQuota, @from, @until, @shift)";

        private const string UPDATE = "UPDATE courses " +
               "SET cr_name = @name, " +
               "cr_description = @description, " +
               "cr_maximum_quota = @maximumQuota, " +
               "cr_from = @from, " +
               "cr_until = @until, " +
               "cr_shift = @shift " +
               "WHERE cr_code = @code";

        private const string DELETE = "DELETE FROM courses WHERE cr_code = @codigoCurso";
              

        public CourseRepositoryImpl() : base() {
            
        }

        public Course DeleteById(int id){
            throw new NotImplementedException();
        }

        public bool DeleteByCode(int code) {
            Console.WriteLine("*****[REPO]DeleteByCode.Course*******");
            bool rslt = false;
            int rowsAffected = 0;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(DELETE, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@code", code);

                rowsAffected = _mySqlComnd.ExecuteNonQuery();
                rslt = (rowsAffected > 0) ? true : false;
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return rslt;
        }

        public bool Update(Course course) {
            Console.WriteLine("*****[REPO]Update.Course*******");
            bool rslt = false;
            int rowsAffected = 0;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(UPDATE, _mySqlConn);

                _mySqlComnd.Parameters.AddWithValue("@name", course.Name);                
                _mySqlComnd.Parameters.AddWithValue("@description", course.Description);
                _mySqlComnd.Parameters.AddWithValue("@maximumQuota", course.MaxQuota);
                _mySqlComnd.Parameters.AddWithValue("@from", course.From);
                _mySqlComnd.Parameters.AddWithValue("@until", course.Until);
                _mySqlComnd.Parameters.AddWithValue("@shift", course.Shift);

                _mySqlComnd.Parameters.AddWithValue("@code", course.Code);

                rowsAffected = _mySqlComnd.ExecuteNonQuery();
                rslt = (rowsAffected > 0) ? true : false;
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return rslt;
        }

        public bool Save(Course course){
            Console.WriteLine("*****[REPO]Save.Course*******");
            bool rslt = false;
            int rowsAffected = 0;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(INSERT, _mySqlConn);

                _mySqlComnd.Parameters.AddWithValue("@name", course.Name);
                _mySqlComnd.Parameters.AddWithValue("@code", course.Code);
                _mySqlComnd.Parameters.AddWithValue("@description", course.Description);
                _mySqlComnd.Parameters.AddWithValue("@maximumQuota", course.MaxQuota);
                _mySqlComnd.Parameters.AddWithValue("@from", course.From);
                _mySqlComnd.Parameters.AddWithValue("@until", course.Until);
                _mySqlComnd.Parameters.AddWithValue("@shift", course.Shift);

                rowsAffected = _mySqlComnd.ExecuteNonQuery();
                rslt = (rowsAffected > 0) ? true : false;
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return rslt;
        }

        public List<Course> GetAll(){
            Console.WriteLine("*****[REPO] GetAll*******");
            List<Course> courses = new List<Course>();
            Course course = null;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_ALL, _mySqlConn);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read())
                {
                    course = new Course();
                    course.Id = _mySqlRead.GetInt32("id");
                    course.Name = _mySqlRead.GetString("cr_name");
                    course.Code = _mySqlRead.GetInt32("cr_code");
                    course.Description = _mySqlRead.GetString("cr_description");
                    course.MaxQuota = _mySqlRead.GetInt32("cr_maximum_quota");
                    course.From = _mySqlRead.GetDateTime("cr_from");
                    course.Until = _mySqlRead.GetDateTime("cr_until");
                    course.Shift = _mySqlRead.GetString("cr_shift");

                    courses.Add(course);
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return courses;
        }

        public Course GetByCode(int code) {
            Console.WriteLine("*****[REPO] GetByCode*******");
            Course course = null;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_BY_CODE, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@code", code);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()){
                    course = new Course();
                    course.Id = _mySqlRead.GetInt32("id");
                    course.Name = _mySqlRead.GetString("cr_name");
                    course.Code = _mySqlRead.GetInt32("cr_code");
                    course.Description = _mySqlRead.GetString("cr_description");
                    course.MaxQuota = _mySqlRead.GetInt32("cr_maximum_quota");
                    course.From = _mySqlRead.GetDateTime("cr_from");
                    course.Until = _mySqlRead.GetDateTime("cr_until");
                    course.Shift = _mySqlRead.GetString("cr_shift");
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return course;
        }

        public Course GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
