using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Data;
using VillanuevaITELEC1C.Models;

namespace VillanuevaITELEC1C.Controllers
{

    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbData;
        public InstructorController(AppDbContext dbData)
        {
            _dbData = dbData;
        }
    public IActionResult Index()
        {
            
            return View(_dbData.Instructors);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if (!ModelState.IsValid)
                return View();

            _dbData.Instructors.Add(newInstructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.OfficePhone = instructorChanges.OfficePhone;
                _dbData.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Instructor newInstructor)

        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.Id == newInstructor.Id);

            if (instructor != null)//was an instructor found?
                _dbData.Instructors.Remove(instructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
    }
};
