using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Diary.Data_Access_Layer
{
    class User_Data_Access
    {
        DataAccess dataAccess;
        public User_Data_Access()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
