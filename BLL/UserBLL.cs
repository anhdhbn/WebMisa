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
        public string CheckLogin(string username, string password)
        {
            if(validate(username, password))
            {
                //TODO
            }
            return "error";
        }
        public string getDisplayName(Guid userID)
        {
            return _userDLL.GetUserById(userID).Name;
        }
        public string getAvatarURL(Guid userID)
        {
            return _userDLL.GetUserById(userID).Image;
        }
        private bool validate(string username, string password)
        {
            //TODO
            return true;
        }
    }
}
