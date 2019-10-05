using System;
using System.Collections.Generic;
using System.Text;

namespace Church.API.Models.AppModel.Request
{
    public class ChangePasswordQuestionnaire : ChangePassword
    {
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
    }
}
