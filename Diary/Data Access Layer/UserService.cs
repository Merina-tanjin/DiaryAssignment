using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Data_Access_Layer;

namespace Diary.Data_Access_Layer
{
    class UserService
    {
        User_Data_Access userDataAccess;
        public UserService()
        {
            userDataAccess = new User_Data_Access();
        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LoginValidation(username, password);
        }
    }
}
