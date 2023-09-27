using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcadCore.ar.com.sysacad.repository.impl
{
    public abstract class BaseRepository
    {
        protected const string CONNN_URL = "server=localhost; uid=root; database=sysacad_db; port=3306; pwd=root;";

        protected MySqlConnection _mySqlConn;
        protected MySqlCommand _mySqlComnd;
        protected MySqlDataReader _mySqlRead;

        public MySqlConnection MySqlConn { get => _mySqlConn; }
        public MySqlCommand MySqlCom { get => _mySqlComnd; }
        public MySqlDataReader MySqlRead { get => _mySqlRead; }

    }
}
