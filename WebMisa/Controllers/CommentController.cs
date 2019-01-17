using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo.Models;

namespace WebMisa.Controllers
{
    public class CommentController : ApiController
    {
        public List<Comment> GetAllCommentByStatusID(int statusID)
        {
            //TODO: trả về tất cả comment của status
            return null;
        }
        public Comment GetCommentByID(int id)
        {
            //trả về comment theo ID
            return null;
        }

        [HttpPost]
        public void PostComment(int statusId, int userID)
        {

        }
        [HttpDelete]
        public void DeleteComment(int id)
        {

        }
    }
}