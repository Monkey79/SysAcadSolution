﻿using MySql.Data.MySqlClient;
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

        public LoginRepositoryImpl() {
            Console.WriteLine("***LoginRepositoryImpl****");
            _mySqlConn = new MySqlConnection(CONNN_URL);
        }

        public User DeleteById(int id){
            throw new NotImplementedException();
        }

        public User GetByUsername(string username) {
            Console.WriteLine("********GetByUsername**********");
            try{
                _mySqlConn.Open();
                _mySqlComnd = new MySqlCommand(GET_BY_NAME, _mySqlConn);
                _mySqlComnd.Parameters.AddWithValue("@name", username);
                _mySqlRead = _mySqlComnd.ExecuteReader();

                while (_mySqlRead.Read())
                {
                    Console.WriteLine("->id->" + _mySqlRead.GetInt32("id"));
                    Console.WriteLine("->name->" + _mySqlRead.GetString("us_name"));
                    Console.WriteLine("->pass->" + _mySqlRead.GetString("us_password"));
                    Console.WriteLine("->role->" + _mySqlRead.GetString("us_role"));
                    Console.WriteLine("->role->" + _mySqlRead.GetInt32("us_entity_id"));
                }
                _mySqlRead.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
            }finally {
                _mySqlConn.Close();
            }
            return null;
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
                    user.EntityId = _mySqlRead.GetInt32("us_entity_id");

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


        public User Save(User entity){
            throw new NotImplementedException();
        }

        public User SaveUser(string username, string password){
            throw new NotImplementedException();
        }
    }
}
