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
                    InstructorName = "Gabriel Montano",
                    DateHired = DateTime.Now,
                    InstructorEmail = "gmontano@ust.edu.ph",
                    InstructorRank = rank.Instructor
                },

                new Instructor()
                {
                    InstructorName = "Leo Lintag",
                    DateHired = DateTime.Parse("29/01/2005"),
                    InstructorEmail = "llintag@ust.edu.ph",
                    InstructorRank = rank.Assitant
                },

                new Instructor()
                {
                    InstructorName = "Eugenia Zhuo",
                    DateHired = DateTime.Parse("25/08/2002"),
                    InstructorEmail = "ezhuo@ust.edu.ph",
                    InstructorRank = rank.Prof
                }
    };
    public IActionResult Index()
        {
            
            return View(Instructorlist);
        }
    }
};
