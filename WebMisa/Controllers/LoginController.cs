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
        [HttpGet]
        public bool CheckInfoLogin(string userName, string password)
        {
            //TO DO: check login infor
            return true;
        }
    }
}