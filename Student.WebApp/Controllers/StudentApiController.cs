using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Service.Service;

namespace Student.WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentApiController(IStudentService studentService)
        {
            _studentService = studentService;
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
