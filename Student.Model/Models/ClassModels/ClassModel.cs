using Student.DataAcess.Entities;
using System.ComponentModel.DataAnnotations;

namespace Student.Model.Models.ClassModels
{
    public class ClassModel
    {
        public int ClassId { get; set; }
        [Required(ErrorMessage ="This field is required !")]
        public string ClassName { get; set; }
        [Required(ErrorMessage = "This field is required !")]
        public int Capatity { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
