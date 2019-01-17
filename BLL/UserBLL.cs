using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {

        public string CheckLogin(string username, string password)
        {
            if(validate(username, password))
            {
                
            }
            return "error";
        }
        public string getDisplayName(int userID)
        {
            if (true)
            {
                return "name";
            }
            else
            {
                return "error";
            }
        }
        public string getAvatarURL(int userID)
        {
            if (true)
            {
                return "url";
            }
            else
            {
                return "error";
            }
        }
        private bool validate(string username, string password)
        {

            return true;
        }
    }
}
