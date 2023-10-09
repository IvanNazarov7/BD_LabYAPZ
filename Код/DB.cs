using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код
{
    internal class DB
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost; port = 3306; username = root; password = Fucking7@com; database = Курсова;");
        
        public void openConnection()
        {
            if(mySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                mySqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return mySqlConnection;
        }
    }
}
