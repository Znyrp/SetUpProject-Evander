using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Models;

namespace VillanuevaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>()
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
                },
        };
    public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == studentChanges.StudentId);
            
            if (student != null)
            {
                student.StudentFirstName = studentChanges.StudentFirstName;
                student.StudentLastName = studentChanges.StudentLastName;
                student.Email = studentChanges.Email;
                student.DateEnrolled = studentChanges.DateEnrolled;
                student.GPA = studentChanges.GPA;
                student.StudentCourse = studentChanges.StudentCourse;
            }
            return View("Index",StudentList);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student newStudent)

        {
            //Search for the instructor whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == newStudent.StudentId);

            if (student != null)//was an instructor found?
                StudentList.Remove(student);
            return View("Index", StudentList);
        }
    }
};

