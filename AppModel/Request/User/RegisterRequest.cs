using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Models.AppModel.Request.User
{
    public class RegisterRequest
    {
        public string AuthGroupName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private string _status = "P";
        public string Status
        {
            get { return _status; }
            set { this._status = string.IsNullOrEmpty(value) ? _status : value; }
        }

        public string UserAdded { get; set; }
        
        public List<int> OrganizationIdList { get; set; }
        public List<int> UserRoleIdList { get; set; }

        public List<UserQuestionAnswerModel> UserQuestionAnswerList { get; set; }
    }

    public class UserQuestionAnswerModel
    {
        public int UserSecurityQuestionId { get; set; }
        public string Answer { get; set; }
    }
}
