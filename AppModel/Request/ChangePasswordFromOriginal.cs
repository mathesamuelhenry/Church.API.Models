using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Church.API.Models.AppModel.Request
{
    public class ChangePasswordFromOriginal : ChangePassword
    {
        [Required]
        public string OriginalPassword { get; set; }
    }
}
