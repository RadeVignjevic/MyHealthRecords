using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHealthRecords.Models
{
    public class AddToRoleModel
    {
        public string email { get; set; }
        public List<String> roles { get; set; }
        public string selectedRole { get; set; }
    }
}