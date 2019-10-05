using System;
using System.Collections.Generic;

namespace Church.API.Models
{
    public partial class Kvp
    {
        public int KvpId { get; set; }
        public string KvpName { get; set; }
        public string KvpKey { get; set; }
        public string KvpValue { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateChanged { get; set; }
    }
}
