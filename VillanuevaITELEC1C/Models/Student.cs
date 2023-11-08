using System.ComponentModel.DataAnnotations;

namespace VillanuevaITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string? StudentFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string? StudentLastName { get; set; }

        [Display(Name = "Date Enrolled")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select a Date")]
        public DateTime? DateEnrolled { get; set; }

        [Required]
        public Course StudentCourse { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter your Email Address")]
        [Display(Name = "Email Address")]
        public string? Email { get; set; }

        [Display(Name = "GPA")]
        [Required(ErrorMessage = "Please Enter GPA")]
        [Range(1.00, 5.00, ErrorMessage = "GPA must only be between 1.00 - 5.00")]
        public double? GPA { get; set; }

        [Display(Name = "Telephone Number")]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "you must follow the format 000-000-0000! for the Telephone Number")]
        public string? PhoneNumber { get; set; }
    }
}
