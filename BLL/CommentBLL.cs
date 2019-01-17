using DLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentBLL
    {
        CommentDLL _commentDLL = new CommentDLL();
        public ICollection<Comment> GetAllCommentByStatusID(Guid statusID)
        {
            return null;
        }
        public Comment GetCommentByID(Guid id)
        {
            return _commentDLL.GetCommentById(id);
        }
    }
}
