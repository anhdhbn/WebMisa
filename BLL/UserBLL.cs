using DLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {

        UserDLL _userDLL = new UserDLL();
        public Guid CheckLogin(string username, string password)
        {
            return _userDLL.CheckUserInfo(username, password);
        }
        public string getDisplayName(Guid userID)
        {
            return _userDLL.GetUserById(userID).Name;
        }
        public string getAvatarURL(Guid userID)
        {
            return _userDLL.GetUserById(userID).Image;
        }
    }
}
