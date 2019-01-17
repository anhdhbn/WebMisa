using DLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StatusBLL
    {
        StatusDLL _statusDLL = new StatusDLL();
        public Status GetPostByID(Guid id)
        {
            return _statusDLL.GetStatusById(id);
        }
        public ICollection<Status> GetPostsByUserID(Guid userID)
        {
            _statusDLL.GetAllStatusByUserId(userID);
            return null;
        }
    }
}
