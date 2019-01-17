using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo.Models;

namespace WebMisa.Controllers
{
    public class LikeController : ApiController
    {
        public List<Like> GetLikeOfStatus(int statusID)
        {
            //TODO: trả về danh sách user đã like status
            return null;
        }

        public Like GetLikeById(int id)
        {
            //trả về thông tin user like status
            return null;
        }
        [HttpPost]
        public void LikeStatus(int statusId, int userID)
        {
            
        }
        [HttpDelete]
        public void Unlike(int id)
        {

        }
    }
}