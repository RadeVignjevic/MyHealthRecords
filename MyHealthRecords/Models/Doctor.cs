using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyHealthRecords.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Surname { get; set; }
        [Required]
        public int Age { get; set; }
        public String Address { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Diagnose> Diagnoses { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }


    }
}