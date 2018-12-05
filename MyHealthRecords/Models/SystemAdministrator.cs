using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyHealthRecords.Models
{
    public class SystemAdministrator
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }


    }
}