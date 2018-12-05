using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyHealthRecords.Models
{
    public class Diagnose
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Date { get; set; }
        [Required]
        public String Description { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

    }
}