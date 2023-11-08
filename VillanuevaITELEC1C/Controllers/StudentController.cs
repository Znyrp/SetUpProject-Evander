using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Data;
using VillanuevaITELEC1C.Models;

namespace VillanuevaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbData;
        public StudentController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

       
    public IActionResult Index()
        {

            return View(_dbData.Students);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

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
            if (!ModelState.IsValid)
                return View();

            _dbData.Students.Add(newStudent);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == studentChanges.Id);

            if (student != null)
            {
                student.StudentFirstName = studentChanges.StudentFirstName;
                student.StudentLastName = studentChanges.StudentLastName;
                student.Email = studentChanges.Email;
                student.DateEnrolled = studentChanges.DateEnrolled;
                student.GPA = studentChanges.GPA;
                student.StudentCourse = studentChanges.StudentCourse;
                student.PhoneNumber = studentChanges.PhoneNumber;

                _dbData.SaveChanges(); // Save changes after making all the necessary updates
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student newStudent)

        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == newStudent.Id);

            if (student != null)//was an instructor found?
                _dbData.Students.Remove(student);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
    }
};

