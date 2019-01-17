using BLL;
using Entity;
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
        [HttpGet]
        [Route("user/name/{id}")]
        public string GetUserDisplayName(Guid id)
        {
            return _userBLL.getDisplayName(id); 
            
        }

        [HttpGet]
        [Route("user/image/{id}")]
        public string GetUserImage(Guid id)
        {
            return _userBLL.getAvatarURL(id);

        }
        
    }
}