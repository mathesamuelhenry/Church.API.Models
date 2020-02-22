using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class Users
    {
        public Users()
        {
            // UserOrganization = new HashSet<UserOrganization>();
            UserRole = new HashSet<UserRole>();
            UserSecurityQuestion = new HashSet<UserSecurityQuestion>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        //public virtual ICollection<UserOrganization> UserOrganization { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<UserSecurityQuestion> UserSecurityQuestion { get; set; }
    }
}
