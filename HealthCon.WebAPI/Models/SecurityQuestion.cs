using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class SecurityQuestion
    {
        public SecurityQuestion()
        {
            Users = new HashSet<User>();
        }

        public int SecurityQuestionId { get; set; }
        public string SecurityQusetion { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
