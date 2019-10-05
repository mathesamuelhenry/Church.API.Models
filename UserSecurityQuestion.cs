using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class UserSecurityQuestion
    {
        public int UserSecurityQuestionId { get; set; }
        public int UserId { get; set; }
        public int SecurityQuestionId { get; set; }
        public string Answer { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        //public virtual SecurityQuestion SecurityQuestion { get; set; }
        // public virtual Users User { get; set; }
    }
}
