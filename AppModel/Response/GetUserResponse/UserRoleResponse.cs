using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Models.AppModel.Response.GetUserResponse
{
    public class UserRoleResponse
    {
        public int UserRoleId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
