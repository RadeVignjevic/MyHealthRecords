using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyHealthRecords.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Surname { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be a positive number > 0")]
        public int Age { get; set; }
        public String Address { get; set; }
        public virtual ICollection<Diagnose> Diagnosis { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }


    }
}