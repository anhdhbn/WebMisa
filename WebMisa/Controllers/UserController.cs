using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebMisa.Controllers
{
    public class UserController : ApiController
    {
        UserBLL _userBLL = new UserBLL();
        // GET api/User?id=
        public Demo.Models.User GetUserInfo(int id)
        {
            return null;
        }
        
        public string GetUserDisplayName(int id, bool getName)
        {
            if (getName)
            {
                //TODO: trả về DisplayName
                _userBLL.getDisplayName(id);
                return "";
            }
            return "";
        }

        public string GetUserAvatar(int id, bool getAvatar)
        {
            if (getAvatar)
            {
                //TODO: trả về url của hình đại diện
                return _userBLL.getAvatarURL(id);
            }
            return "";
        }
    }
}