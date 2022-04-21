using Microsoft.AspNetCore.Mvc;
using Student.Model.Models.StudentModels;
using Student.Service.AutoMap;
using Student.Service.Service;

namespace Student.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var model = new StudentModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(StudentModel model)
        {
            _studentService.Insert(model.MapToEntity());
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult GetStudents()
        {
            var pageSize = int.Parse(Request.Form["length"]);
            var skip = int.Parse(Request.Form["start"]);
            var textSearch = Request.Form["search[value]"];

            var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            var sortColumnDirection = Request.Form["order[0][dir]"];

            var students = _studentService.GetAllStudent(pageSize, skip, textSearch, sortColumn, sortColumnDirection);
            var totalRecord = students.Count();
            return Ok(new { recordsFiltered = totalRecord, recordsTotal = totalRecord, data = students });
        }
    }
}
