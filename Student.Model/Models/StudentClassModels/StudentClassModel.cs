using Student.DataAcess.Entities;

namespace Student.Model.Models.StudentClassModels
{
    public class StudentClassModel
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public Student.DataAcess.Entities.Student Student { get; set; }
    }
}
