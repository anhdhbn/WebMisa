using System;
using System.Collections.Generic;

namespace Demo.Models
{
    public partial class Like
    {
        public Guid Id { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
