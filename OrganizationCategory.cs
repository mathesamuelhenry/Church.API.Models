using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class OrganizationCategory
    {
        public int OrganizationCategoryId { get; set; }
        public int OrganizationId { get; set; }
        public string CategoryName { get; set; }
        public sbyte? IsActive { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
