using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Models.AppModel.Request.User
{
    public class Register
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private string _status = "A";
        public string Status
        {
            get { return _status; }
            set { this._status = string.IsNullOrEmpty(value) ? _status : value; }
        }

        public string UserAdded { get; set; }
        
        public List<int> OrganizationIdList { get; set; }
        public List<int> UserRoleIdList { get; set; }

        public List<UserQuestionAnswer> UserQuestionAnswerList { get; set; }
    }

    public class UserQuestionAnswer
    {
        public int UserSecurityQuestionId { get; set; }
        public string Answer { get; set; }
    }
}
