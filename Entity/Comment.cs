using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Comment
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? StatusId { get; set; }
        public string ContentComment { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
