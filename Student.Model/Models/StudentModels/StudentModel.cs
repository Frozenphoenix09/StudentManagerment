using Student.DataAcess.Entities;
using System.ComponentModel.DataAnnotations;

namespace Student.Model.Models.StudentModels
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "This field is required !")]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
