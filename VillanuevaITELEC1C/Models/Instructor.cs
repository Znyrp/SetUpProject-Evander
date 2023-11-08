using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace VillanuevaITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string? FirstName { get; set;}
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set;}
        [Display(Name = "Is Tenured")]
        public bool IsTenured { get; set; }
        [Display(Name = "Rank")]

        [Required]
        public Rank Rank { get; set; }
        [Display(Name = "Date Hired")]
        [Required(ErrorMessage = "Please select a Date")]
        [DataType(DataType.Date)]
        public DateTime? HiringDate { get; set; }

        [Display(Name = "Office Phone Number")]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "you must follow the format 000-000-0000! for the Office Phone Number")]
        public string? OfficePhone { get; set; }
    }
}
