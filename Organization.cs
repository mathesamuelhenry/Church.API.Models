using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class Organization
    {
        public Organization()
        {
            OrganizationCategory = new HashSet<OrganizationCategory>();
            UserOrganization = new HashSet<UserOrganization>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public int? IndustryId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public virtual Industry Industry { get; set; }
        public virtual ICollection<OrganizationCategory> OrganizationCategory { get; set; }
        public virtual ICollection<UserOrganization> UserOrganization { get; set; }
    }
}
