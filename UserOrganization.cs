using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class UserOrganization
    {
        public int UserOrganizationId { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public virtual Organization Organization { get; set; }
        //public virtual Users User { get; set; }
    }
}
