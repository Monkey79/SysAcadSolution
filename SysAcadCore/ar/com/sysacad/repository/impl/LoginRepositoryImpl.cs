using MySql.Data.MySqlClient;
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
        private const string GET_USER_BY_NAME = "SELECT * from users WHERE name=?";
        private const string GET_ALL = "SELECT * FROM users";

        public LoginRepositoryImpl() {
            Console.WriteLine("***LoginRepositoryImpl****");
            _mySqlConn = new MySqlConnection(CONNN_URL);
        }

        public User DeleteById(int id){
            throw new NotImplementedException();
        }

        public List<User> GetAll(){
            Console.WriteLine("********GET ALL******************");
            try
            {
                _mySqlConn.Open();
                Console.WriteLine("***OPEN****");
                _mySqlComnd = new MySqlCommand(GET_ALL, _mySqlConn);
                Console.WriteLine("**_mySqlComnd***" + _mySqlComnd);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read()){
                    Console.WriteLine("->id->" + _mySqlRead.GetInt32("id"));
                    Console.WriteLine("->name->" + _mySqlRead.GetString("name"));
                    Console.WriteLine("->pass->" + _mySqlRead.GetString("password"));
                    Console.WriteLine("->role->" + _mySqlRead.GetString("role"));
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("ERROR--->" + ex.Message);
                Console.WriteLine("ERROR--->" + ex.GetType);
                Console.WriteLine("ERROR--->" + ex);
            }finally{
                _mySqlConn.Close();
            }
            return null;
        }

        public User GetById(int id){
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username){
            throw new NotImplementedException();
        }

        public User Save(User entity){
            throw new NotImplementedException();
        }

        public User SaveUser(string username, string password){
            throw new NotImplementedException();
        }
    }
}
