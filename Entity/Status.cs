using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Status
    {
        public Status()
        {
            Comment = new HashSet<Comment>();
            Like = new HashSet<Like>();
        }

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string ContentStatus { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Like> Like { get; set; }
    }
}
