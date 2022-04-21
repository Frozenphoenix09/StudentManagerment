using Microsoft.AspNetCore.Mvc;

namespace Student.WebApplication.Controller
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
