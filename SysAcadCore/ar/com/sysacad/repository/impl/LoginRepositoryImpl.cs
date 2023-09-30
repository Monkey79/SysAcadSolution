using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using SysAcadCore.ar.com.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository.impl
{
    public class LoginRepositoryImpl : BaseRepository, LoginRepository
    {
        private const string GET_BY_NAME = "SELECT * from users WHERE us_name=@name";
        private const string GET_ALL = "SELECT * FROM users";
        private const string INSERT_USER = "INSERT INTO users(us_name, us_password, us_role) " +
            "VALUES(@userName, @password, @role)";

        public LoginRepositoryImpl() : base(){
            Console.WriteLine("***LoginRepositoryImpl****");            
        }

        public User DeleteById(int id){
            throw new NotImplementedException();
        }

        public User GetByUsername(string username) {
            Console.WriteLine("*****[REPO] GetByUsername*******");
            User user = null;
            try
            {
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_BY_NAME, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@name", username);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()) {
                    user = new User();
                    user.Id = _mySqlRead.GetInt32("id");
                    user.Name = _mySqlRead.GetString("us_name");
                    user.Password = _mySqlRead.GetString("us_password");
                    user.Role = _mySqlRead.GetString("us_role");
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally {
                _mySqlConn.Close();
            }
            return user;
        }

        public List<User> GetAll(){
            Console.WriteLine("********REPO GetAll**********");
            List<User> list = new List<User>();
            try{
                User user = null;
                _mySqlConn.Open();                
                _mySqlComnd = new MySqlCommand(GET_ALL, _mySqlConn);                
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()){
                    user = new User();
                    user.Id = _mySqlRead.GetInt32("id");
                    user.Name = _mySqlRead.GetString("us_name");
                    user.Password = _mySqlRead.GetString("us_password");
                    user.Role = _mySqlRead.GetString("us_role");
                    list.Add(user);
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: "+ex.Message);
            }finally{
                _mySqlConn.Close();
            }
            return list;
        }

        public User GetById(int id){
            throw new NotImplementedException();
        }


        public bool Save(User user){
            Console.WriteLine("*****[REPO]Save.User*******");
            bool rslt = false;
            int rowsAffected = 0;
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(INSERT_USER, _mySqlConn);

                _mySqlComnd.Parameters.AddWithValue("@userName", user.Name);
                _mySqlComnd.Parameters.AddWithValue("@password", user.Password);
                _mySqlComnd.Parameters.AddWithValue("@role", user.Role);

                rowsAffected = _mySqlComnd.ExecuteNonQuery();
                rslt = (rowsAffected > 0) ? true : false;
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
            }finally {
                _mySqlConn.Close();
            }
            return rslt;
        }

        public bool Update(User entity){
            throw new NotImplementedException();
        }
    }
}
