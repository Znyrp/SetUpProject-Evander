using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Models;
using VillanuevaITELEC1C.Services;

namespace VillanuevaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _dummyData;
        public StudentController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }

       
    public IActionResult Index()
        {

            return View(_dummyData.StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

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
            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == studentChanges.StudentId);
            
            if (student != null)
            {
                student.StudentFirstName = studentChanges.StudentFirstName;
                student.StudentLastName = studentChanges.StudentLastName;
                student.Email = studentChanges.Email;
                student.DateEnrolled = studentChanges.DateEnrolled;
                student.GPA = studentChanges.GPA;
                student.StudentCourse = studentChanges.StudentCourse;
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student newStudent)

        {
            //Search for the instructor whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == newStudent.StudentId);

            if (student != null)//was an instructor found?
                _dummyData.StudentList.Remove(student);
            return RedirectToAction("Index");
        }
    }
};

