using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Models.AppModel.Response.GetUserResponse
{
    public class UserOrganizationResponse
    {
        public int UserOrganizationId { get; set; }
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
    }
}
