using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Models;

namespace VillanuevaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> Instructorlist = new List<Instructor>()
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
    public IActionResult Index()
        {
            
            return View(Instructorlist);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = Instructorlist.FirstOrDefault(ins => ins.Id == id);

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
            Instructorlist.Add(newInstructor);
            return View("Index", Instructorlist);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = Instructorlist.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = Instructorlist.FirstOrDefault(ins => ins.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;
                instructor.HiringDate = instructorChanges.HiringDate;
            }
            return View("Index", Instructorlist);
        }

    }
};
