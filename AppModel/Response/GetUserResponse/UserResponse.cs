using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Models.AppModel.Response.GetUserResponse
{
    public class UserResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserStatus { get; set; }
        public string EmailId { get; set; }
        public List<UserRoleResponse> UserRole { get; set; }
        public List<UserOrganizationResponse> UserOrganization { get; set; }
    }
}
