namespace VillanuevaITELEC1C.Models
{
    public enum rank
    {
        Instructor, Assitant, Prof
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set;}
        public string InstructorEmail { get; set;}
        public DateTime DateHired { get; set; }
        public rank InstructorRank { get; set; }
    }
}
