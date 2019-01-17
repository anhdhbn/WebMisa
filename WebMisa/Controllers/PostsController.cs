using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entity;

namespace WebMisa.Controllers
{
    public class PostsController : ApiController
    {
        StatusBLL _statusBLL = new StatusBLL();
        public List<Status> GetNewestPost()
        {
            //TODO: trả về list status mới nhất 
            return null;
        }

        public Status GetPostByID(Guid id)
        {
            return _statusBLL.GetPostByID(id);
        }
        public ICollection<Status> GetPostsByUserID(Guid userID)
        {
            return _statusBLL.GetPostsByUserID(userID);
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