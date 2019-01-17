using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Entity;

namespace WebMisa.Controllers
{
    public class LikesController : ApiController
    {
        LikeBLL _likeBLL = new LikeBLL();
        [HttpGet]
        [Route("api/likes/count")]
        public int CountLikeByStatusID(Guid statusId)
        {
            return _likeBLL.CountLikesByStatusId(statusId);
        }
        [HttpPost]
        public void LikeStatus(Guid statusId, Guid userID)
        {
            
        }
        [HttpDelete]
        public void Unlike(Guid id)
        {

        }
    }
}