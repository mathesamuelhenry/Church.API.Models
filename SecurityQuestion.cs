using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class SecurityQuestion
    {
        public SecurityQuestion()
        {
            // UserSecurityQuestion = new HashSet<UserSecurityQuestion>();
        }

        public int SecurityQuestionId { get; set; }
        public string Question { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateChanged { get; set; }

        // public virtual ICollection<UserSecurityQuestion> UserSecurityQuestion { get; set; }
    }
}
