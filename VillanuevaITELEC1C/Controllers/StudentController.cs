using Microsoft.AspNetCore.Mvc;
using VillanuevaITELEC1C.Models;

namespace VillanuevaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
       
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 2021151795;
            st.StudentName = "Evander Prynz R. Villanueva";
            st.DateEnrolled = DateTime.Parse("08/05/2023");
            st.StudentCourse = Course.BSIT;
            st.Email = "evanderprynz.villanueva.cics@ust.edu.ph";

            ViewBag.Student = st;
            return View();

            
        }
    }
}
