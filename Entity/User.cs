using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            Like = new HashSet<Like>();
            Notification = new HashSet<Notification>();
            Status = new HashSet<Status>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Like> Like { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<Status> Status { get; set; }
    }
}
