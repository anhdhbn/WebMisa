using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LikeBLL
    {
        LikeDLL _likeDLL = new LikeDLL();
        public int CountLikesByStatusId(Guid StatusId)
        {
            return _likeDLL.CountLikesByStatusId(StatusId);
        }
    }
}
