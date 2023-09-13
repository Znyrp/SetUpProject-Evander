namespace VillanuevaITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public DateTime DateEnrolled { get; set; }
        public Course StudentCourse { get; set; }
        public string Email { get; set; }
        public double GPA { get; set; }
    }
}
