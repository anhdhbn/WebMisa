using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebMisa.Controllers
{
    public class LoginController : ApiController
    {
        UserBLL _userBLL = new UserBLL();
        [HttpGet]
        public Guid CheckInfoLogin(string userName, string password)
        {
            return _userBLL.CheckLogin(userName, password);
        }
    }
}