using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class Organization
    {
        public Organization()
        {
            UserOrganization = new HashSet<UserOrganization>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Zip4 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public virtual ICollection<UserOrganization> UserOrganization { get; set; }
    }
}
