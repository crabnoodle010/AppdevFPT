using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FPTManagerment.Models
{
    public class TraineeIf
    {
        [Key]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        [DisplayName("Full name")]
        public string FullName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [DisplayName("Number Phone")]
        public int NumberPhone { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}