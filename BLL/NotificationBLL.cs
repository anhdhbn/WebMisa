using DLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NotificationBLL
    {
        NotificationDLL _notificationDLL = new NotificationDLL();
        public ICollection<Notification> GetAllNotificationByUserId(Guid UserId)
        {
            return _notificationDLL.GetAllNotificationByUserId(UserId);
        }
        public ICollection<Notification> GetAllNotificationSystem(Guid UserId)
        {
            return _notificationDLL.GetAllNotificationSystem(UserId);
        }
        public int CountPersonalNotification(Guid id)
        {
            return _notificationDLL.GetAllNotificationByUserId(id).Count;
        }
    }
}
