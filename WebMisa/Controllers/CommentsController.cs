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
    public class CommentsController : ApiController
    {
        CommentBLL _commentBLL = new CommentBLL();
        public ICollection<Comment> GetAllCommentByStatusID(Guid statusID)
        {
            //TODO: trả về tất cả comment của status
            return null;
        }
        public Comment GetCommentByID(Guid id)
        {
            //trả về comment theo ID
            return null;
        }
        [HttpGet]
        int CountCommentByStatusID(Guid countID)
        {
            return 1;
        }
        [HttpPost]
        public void PostComment(Guid statusId, Guid userID)
        {

        }
        [HttpDelete]
        public void DeleteComment(Guid id)
        {

        }
    }
}