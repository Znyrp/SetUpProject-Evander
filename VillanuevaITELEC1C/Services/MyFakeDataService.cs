using VillanuevaITELEC1C.Models;
using VillanuevaITELEC1C.Services;

namespace VillanuevaITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        public MyFakeDataService()
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    StudentId = 1,
                    StudentFirstName = "Evander Prynz",
                    StudentLastName = "Villanueva",
                    Email = "evanderprynz.villanueva.cics@ust.edu.ph",
                    StudentCourse = Course.BSIT,
                    GPA = 1.00,
                    DateEnrolled = DateTime.Parse("02/01/2020"),
                },
                 new Student()
                {
                    StudentId = 2,
                    StudentFirstName = "Jan Drefner",
                    StudentLastName = "Santos",
                    Email = "jandrefner.santos.cics@ust.edu.ph",
                    StudentCourse = Course.BSIT,
                    GPA = 1.25,
                    DateEnrolled = DateTime.Parse("03/02/2020"),
                },
                  new Student()
                {
                    StudentId = 3,
                    StudentFirstName = "Mark Clarence",
                    StudentLastName = "Alicante",
                    Email = "markclarence.alicante.cics@ust.edu.ph",
                    StudentCourse = Course.BSCS,
                    GPA = 1.50,
                    DateEnrolled = DateTime.Parse("22/01/2020"),
                },
                   new Student()
                {
                    StudentId = 4,
                    StudentFirstName = "Zyke",
                    StudentLastName = "Victoria",
                    Email = "zyke.victoria.cics@ust.edu.ph",
                    StudentCourse = Course.BSIS,
                    GPA = 1.25,
                    DateEnrolled = DateTime.Parse("10/11/2020"),
                },
                    new Student()
                {
                    StudentId = 5,
                    StudentFirstName = "Louis Ivan",
                    StudentLastName = "Virgo",
                    Email = "louisivan.virgo.cics@ust.edu.ph",
                    StudentCourse = Course.BSIT,
                    GPA = 1.75,
                    DateEnrolled = DateTime.Parse("03/02/2020"),
                }
             };


            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Gabriel",
                    LastName = "Montano",
                    IsTenured = true,
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("29/01/2020")
                },

                new Instructor()
                {
                    Id = 2,
                    FirstName = "Leo",
                    LastName = "Lintag",
                    IsTenured= false,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("09/08/2005")
                },

                new Instructor()
                {
                    Id = 3,
                    FirstName = "Eugenia",
                    LastName = "Zhuo",
                    IsTenured= true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("10/10/2009")
                },

                 new Instructor()
                {
                    Id = 4,
                    FirstName = "Mike",
                    LastName = "Victorio",
                    IsTenured= true,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("10/12/2010")
                }
             };
        }
    }
}

