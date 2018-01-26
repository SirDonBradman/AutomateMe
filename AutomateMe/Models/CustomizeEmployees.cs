using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomateMe.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        public bool IsSelected { get; set; }
    }

    public class EmployeeMetadata
    {
        [Required]
        [Range(1,500, ErrorMessage ="ID cannot be greater than 500")]
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Max length for name is 50")]
        public string Name { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Please select a gender")]
        public string Gender { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Max length for Maritial Status is 8")]
        [Display(Name = "Maritial Status")]
        public string MaritialStatus { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Max length for Address is 100")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of birth")]
        public System.DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Is Current")]
        public bool IsCurrent { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "please enter a valid email")]
        public string Email { get; set; }

        [Required]
        [MinLength(10, ErrorMessage ="Minimum length for phone number is 10")]
        [MaxLength(13, ErrorMessage ="Max length for phone number is 13")]
        [DataType(DataType.PhoneNumber, ErrorMessage ="Please enter a valid contact number")]
        public string Phone { get; set; }
    }
}