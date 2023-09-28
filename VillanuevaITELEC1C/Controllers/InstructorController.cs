using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Models;
using VillanuevaITELEC1C.Services;

namespace VillanuevaITELEC1C.Controllers
{

    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;
        public InstructorController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }
    public IActionResult Index()
        {
            
            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.Id == id);

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
            _dummyData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;
                instructor.HiringDate = instructorChanges.HiringDate;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Instructor newInstructor)

        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.Id == newInstructor.Id);

            if (instructor != null)//was an instructor found?
                _dummyData.InstructorList.Remove(instructor);
            return RedirectToAction("Index");
        }
    }
};
