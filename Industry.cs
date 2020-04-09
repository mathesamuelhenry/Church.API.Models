using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class Industry
    {
        public Industry()
        {
        }

        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
