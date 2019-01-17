using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo.Models;

namespace WebMisa.Controllers
{
    public class PostsController : ApiController
    {
        public List<Status> GetNewestPost()
        {
            //TODO: trả về list status mới nhất 
            return null;
        }

        public Status GetPostByID(int id)
        {
            //TODO: trả về status theo ID
            return null;
        }
        public Status GetPostByUserID(int userID)
        {
            //TODO: trả về status đã đăng của user
            return null;
        }

        [HttpPost]
        public void PostStatus(int userID)
        {

        }
        [HttpDelete]
        public void DeleteStatus(int id)
        {

        }
    }
}