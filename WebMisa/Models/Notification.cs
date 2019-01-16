using System;
using System.Collections.Generic;

namespace Demo.Models
{
    public partial class Notification
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsRead { get; set; }
        public string ContentNotification { get; set; }
        public string RelativeLink { get; set; }
        public Guid? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
