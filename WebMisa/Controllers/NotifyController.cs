using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebMisa.Controllers
{
    public class NotifyController : ApiController
    {
        NotificationBLL _notificationBLL = new NotificationBLL();
        [HttpGet]
        [Route("notify/personal/{id}")]
        public ICollection<Notification> GetAllNotificationByUserId(Guid id)
        {
            return _notificationBLL.GetAllNotificationByUserId(id);
        }
        [HttpGet]
        [Route("notify/global/{id}")]
        public ICollection<Notification> GetAllNotificationSystem(Guid id)
        {
            return _notificationBLL.GetAllNotificationSystem(id);
        }
        [HttpGet]
        [Route("notify/count/{id}")]
        public int CountPersonalNotification(Guid id)
        {
            return _notificationBLL.CountPersonalNotification(id);
        }
    }
}